using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WM.Core.Entities;
using WM.Northwind.Entities.Concrete.Authorization;

namespace WM.Northwind.Entities.Concrete.EczaneNobet
{
    public class EczaneNobetDegisimTalep : IEntity
    {
        public int Id { get; set; }
        public int EczaneNobetDegisimArzId { get; set; }
        //public int EczaneNobetSonucId { get; set; }
        public int EczaneNobetGrupId { get; set; }
        public int UserId { get; set; }
        public DateTime KayitTarihi { get; set; }
        public string  Aciklama { get; set; }
        public virtual User User { get; set; }
        public virtual EczaneNobetGrup EczaneNobetGrup { get; set; }
        //public virtual EczaneNobetSonuc EczaneNobetSonuc { get; set; }
        public virtual EczaneNobetDegisimArz EczaneNobetDegisimArz { get; set; }

    }
}