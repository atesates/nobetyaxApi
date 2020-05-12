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
    public class NobetUstGrupMobilUygulamaController : ApiController
    {
        #region ctor
        private INobetUstGrupService _nobetUstGrupService;
        private IUserService _userService;
        private INobetUstGrupMobilUygulamaService _nobetUstGrupMobilUygulamaService;

        public NobetUstGrupMobilUygulamaController(INobetUstGrupService nobetUstGrupService,
                                    IUserService userService,
                                    INobetUstGrupMobilUygulamaService nobetUstGrupMobilUygulamaService)
        {
            _nobetUstGrupService  = nobetUstGrupService;
            _userService = userService;
            _nobetUstGrupMobilUygulamaService = nobetUstGrupMobilUygulamaService;
        }
        #endregion

        [Route("mobil-yetki/{nobetUstGrupId:int:min(1)}")]
        [HttpGet]
        public List<NobetUstGrupMobilUygulama> Get(int nobetUstGrupId)
        {
            return _nobetUstGrupMobilUygulamaService.GetListByNobetUstGrupId(nobetUstGrupId);
        }


    }
}
