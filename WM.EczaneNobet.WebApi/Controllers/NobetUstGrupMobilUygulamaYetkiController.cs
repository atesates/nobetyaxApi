using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WM.Northwind.Business.Abstract.Authorization;
using WM.Northwind.Business.Abstract.EczaneNobet;
using WM.Northwind.Entities.ComplexTypes.EczaneNobet;
using WM.Northwind.Entities.Concrete.Authorization;
using WM.Northwind.Entities.Concrete.EczaneNobet;

namespace WM.EczaneNobet.WebApi.Controllers
{
    public class NobetUstGrupMobilUygulamaYetkiController : ApiController
    {
        #region ctor
        private IMobilUygulamaYetkiService _mobilUygulamaYetkiService;
        private INobetUstGrupMobilUygulamaYetkiService _nobetUstGrupMobilUygulamaYetkiService;
        private INobetUstGrupService _nobetUstGrupService;
        private IUserService _userService;

        public NobetUstGrupMobilUygulamaYetkiController(IMobilUygulamaYetkiService mobilUygulamaYetkiService,
            INobetUstGrupMobilUygulamaYetkiService ustGrupMobilUygulamaYetkiService,
                                    IUserService userService,
                                    INobetUstGrupService nobetUstGrupService)
        {

            _mobilUygulamaYetkiService = mobilUygulamaYetkiService;
            _nobetUstGrupService = nobetUstGrupService;
            _nobetUstGrupMobilUygulamaYetkiService = ustGrupMobilUygulamaYetkiService;
             _userService = userService;
        }
        #endregion

        [Route("nobet-ust-grup-mobil-uygulama-yetki/{userId:int:min(1)}")]
        [HttpGet]
        public List<NobetUstGrupMobilUygulamaYetkiDetay> Get(int userId)
        {
            User User = _userService.GetById(userId);
            NobetUstGrup nobetUstGrup = _nobetUstGrupService.GetListByUser(User).FirstOrDefault();
            return _nobetUstGrupMobilUygulamaYetkiService.GetDetayListByNobetUstGrupId(nobetUstGrup.Id);
        }


    }
}
