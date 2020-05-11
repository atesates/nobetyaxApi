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
    public class UserNobetUstGrupController : ApiController
    {
        #region ctor
        private INobetUstGrupService _nobetUstGrupService;
        private IUserService _userService;
        private IUserNobetUstGrupService _userNobetUstGrupService;

        public UserNobetUstGrupController(INobetUstGrupService nobetUstGrupservice,
                                            IUserService userService,
                                            IUserNobetUstGrupService userNobetUstGrupService)
        {
            _nobetUstGrupService = nobetUstGrupservice;
            _userService = userService;
            _userNobetUstGrupService = userNobetUstGrupService;
        }
        #endregion

        [Route("user-nobet-ust-grup-detaylar/{userId:int:min(1)}")]
        [HttpGet]
        public List<UserNobetUstGrupDetay> GetNobetUstGrupIdId(int userId)
        {
            return _userNobetUstGrupService.GetDetayListByUserId(userId);
        }

        [Route("user-nobet-ust-grup-detay/{nobetUstGrupId:int:min(1)}")]
        [HttpGet]
        public UserNobetUstGrupDetay Get(int nobetUstGrupId)
        {
            return _userNobetUstGrupService.GetDetayById(nobetUstGrupId);
        }
    }
}
