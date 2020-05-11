﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WM.Core.Entities;
using WM.Northwind.Entities.Concrete.EczaneNobet;


namespace WM.Northwind.Entities.ComplexTypes.EczaneNobet
{
    public class AyniGunNobetTakipGrupAltGrupDetay : IComplexType
    {
        public int Id { get; set; }
        public int NobetUstGrupId { get; set; }
        public int NobetGrupGorevTipId { get; set; }
        public int NobetAltGrupId { get; set; }
        public DateTime BaslamaTarihi { get; set; }
        public DateTime? BitisTarihi { get; set; }
        public string NobetGrupAdi { get; set; }
        public string NobetGorevTipAdi { get; set; }
        public string NobetAltGrupAdi { get; set; }
        public string NobetGrupAdiAltGruplu { get; set; }
        public int KumulatifToplamNobetSayisi { get; set; }
        public int NobetGrupGorevTipIcinTanimliAltGrupSayisi { get; set; }
    }
}