using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WM.Core.Aspects.PostSharp.CacheAspects;
using WM.Core.Aspects.PostSharp.LogAspects;
using WM.Core.Aspects.PostSharp.PerformansCounterAspects;
using WM.Core.Aspects.PostSharp.ValidationAspects;
using WM.Core.CrossCuttingConcerns.Caching.Microsoft;
using WM.Core.CrossCuttingConcerns.Logging.Log4Net.Logger;
using WM.Northwind.Business.Abstract;
using WM.Northwind.Business.Abstract.Authorization;
using WM.Northwind.Business.Abstract.EczaneNobet;
using WM.Northwind.Business.ValidationRules.FluentValidation;
using WM.Northwind.DataAccess.Abstract.Authorization;
using WM.Northwind.DataAccess.Abstract.EczaneNobet;
using WM.Northwind.Entities.ComplexTypes.EczaneNobet;
using WM.Northwind.Entities.Concrete.Authorization;
using WM.Northwind.Entities.Concrete.EczaneNobet;
using WM.Northwind.Entities.Concrete.Optimization.EczaneNobet;
using WM.Optimization.Abstract.Samples;

namespace WM.Northwind.Business.Concrete.Managers.Authorization
{
    public class NobetUstGrupMobilUygulamaManager : INobetUstGrupMobilUygulamaService
    {
        private INobetUstGrupMobilUygulamaDal _nobetUstGrupMobilUygulamaDal;

        public EczaneNobetSonucModel Results { get; set; }

        public NobetUstGrupMobilUygulamaManager(INobetUstGrupMobilUygulamaDal nobetUstGrupMobilUygulamaDal)
        {
            _nobetUstGrupMobilUygulamaDal = nobetUstGrupMobilUygulamaDal;
        }

        [CacheAspect(typeof(MemoryCacheManager))]
        [PerformansCounterAspect(2)]
        //[SecuredOperation(Roles="Admin,Editor,Student")]
        public List<NobetUstGrupMobilUygulama> GetList()
        {
            //Thread.Sleep(3000);    //performanscounterı test için yazıldı
            return _nobetUstGrupMobilUygulamaDal.GetList();
        }

        public NobetUstGrupMobilUygulama GetById(int nobetUstGrupMobilUygulamaId)
        {
            return _nobetUstGrupMobilUygulamaDal.Get(x => x.Id == nobetUstGrupMobilUygulamaId);
        }

        [FluentValidationAspect(typeof(EczaneValidator))]
        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        [LogAspect(typeof(DatabaseLogger))]
        public void Insert(NobetUstGrupMobilUygulama nobetUstGrupMobilUygulama)
        {
            _nobetUstGrupMobilUygulamaDal.Insert(nobetUstGrupMobilUygulama);
        }

        [FluentValidationAspect(typeof(EczaneValidator))]
        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        [LogAspect(typeof(DatabaseLogger))]
        public void Update(NobetUstGrupMobilUygulama nobetUstGrupMobilUygulama)
        {
            _nobetUstGrupMobilUygulamaDal.Update(nobetUstGrupMobilUygulama);
        }

        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        [LogAspect(typeof(DatabaseLogger))]
        public void Delete(int nobetUstGrupMobilUygulamaId)
        {
            _nobetUstGrupMobilUygulamaDal.Delete(new NobetUstGrupMobilUygulama { Id = nobetUstGrupMobilUygulamaId });
        }

        public List<NobetUstGrupMobilUygulama> GetListByNobetUstGrupId(int nobetUstGrupId)
        {
            return _nobetUstGrupMobilUygulamaDal.GetList(w => w.NobetUstGrupId == nobetUstGrupId);
        }

    }
}
