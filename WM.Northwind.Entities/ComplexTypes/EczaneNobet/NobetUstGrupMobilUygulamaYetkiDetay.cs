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
    public class NobetUstGrupMobilUygulamaYetkiDetay: IComplexType
 { 
        public int Id { get; set; }
        public int NobetUstGrupId { get; set; }
        public int MobilUygulamaYetkiId { get; set; }
        public string NobetUstGrupAdi { get; set; }
        public string MobilUygulamaYetkiAdi { get; set; }

    } 
} 