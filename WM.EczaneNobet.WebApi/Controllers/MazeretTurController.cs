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
    public class MazeretTurController : ApiController
    {
        #region ctor
        private IMazeretTurService _mazeretTurService;

        public MazeretTurController(IMazeretTurService mazeretTurService)
        {
            _mazeretTurService = mazeretTurService;
        }
        #endregion

        [Route("mazeret-turler")]
        [HttpGet]
        public List<MazeretTur> Get()
        {
            List<MazeretTur> list = _mazeretTurService.GetList().ToList();
            return list;
        }


    }
}
