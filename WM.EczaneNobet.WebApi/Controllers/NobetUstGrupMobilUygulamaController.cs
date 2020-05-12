using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WM.EczaneNobet.WebApi.Models;
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
        public List<NobetUstGrupMobilUygulamaApi> Get(int nobetUstGrupId)
        {
            List<NobetUstGrupMobilUygulamaApi> listApi = new List<NobetUstGrupMobilUygulamaApi>();
            List<NobetUstGrupMobilUygulama>  list = _nobetUstGrupMobilUygulamaService.GetListByNobetUstGrupId(nobetUstGrupId);
            foreach (var item in list)
            {
                NobetUstGrupMobilUygulamaApi itemApi = new NobetUstGrupMobilUygulamaApi();
                itemApi.Id = item.Id;
                itemApi.MazeretEkleme = item.MazeretEkleme;
                itemApi.MazeretSilme = item.MazeretSilme;
                itemApi.NobetDegisimTalepEkleme = item.NobetDegisimTalepEkleme;
                itemApi.NobetDegisimTalepGorme = item.NobetDegisimTalepGorme;
                itemApi.NobetDegisimTalepSilme = item.NobetDegisimTalepSilme;
                itemApi.OrtalamaIstatistikGorme = item.OrtalamaIstatistikGorme;
                itemApi.NobetUstGrupId = item.NobetUstGrupId;
                listApi.Add(itemApi);
            }
            return listApi;
        }


    }
}
