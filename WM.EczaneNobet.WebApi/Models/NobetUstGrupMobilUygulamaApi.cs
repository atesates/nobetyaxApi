using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WM.EczaneNobet.WebApi.Models
{
    public class NobetUstGrupMobilUygulamaApi
    {
        public int Id { get; set; }
        public int NobetUstGrupId { get; set; }
        public bool MazeretEkleme { get; set; }
        public bool MazeretSilme { get; set; }
        public bool NobetDegisimTalepGorme { get; set; }
        public bool NobetDegisimTalepEkleme { get; set; }
        public bool NobetDegisimTalepSilme { get; set; }
        public bool OrtalamaIstatistikGorme { get; set; }


    }
}