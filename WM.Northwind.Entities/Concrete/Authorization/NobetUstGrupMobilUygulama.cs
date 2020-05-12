using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WM.Core.Entities;
using WM.Northwind.Entities.Concrete.EczaneNobet;

namespace WM.Northwind.Entities.Concrete.Authorization
{
    public class NobetUstGrupMobilUygulama : IEntity
    {
        public int Id { get; set; }
        public int NobetUstGrupId { get; set; }
        public bool MazeretEkleme { get; set; } 
        public bool MazeretSilme { get; set; }
        public bool NobetDegisimTalepGorme { get; set; }
        public bool NobetDegisimTalepEkleme { get; set; }
        public bool NobetDegisimTalepSilme { get; set; }
        public bool OrtalamaIstatistikGorme { get; set; }

        public virtual NobetUstGrup NobetUstGrup { get; set; }
    }
}
