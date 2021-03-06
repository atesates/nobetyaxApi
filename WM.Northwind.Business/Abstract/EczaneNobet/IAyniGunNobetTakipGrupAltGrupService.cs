﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WM.Northwind.Entities.ComplexTypes.EczaneNobet;
using WM.Northwind.Entities.Concrete.EczaneNobet;
using WM.Northwind.Entities.Concrete.Optimization.EczaneNobet;

namespace WM.Northwind.Business.Abstract.EczaneNobet
{
    public interface IAyniGunNobetTakipGrupAltGrupService
    {
        AyniGunNobetTakipGrupAltGrup GetById(int ayniGunNobetTakipGrupAltGId);
        List<AyniGunNobetTakipGrupAltGrup> GetList();
        //List<AyniGunNobetTakipGrupAltGrup> GetByCategory(int categoryId);
        void Insert(AyniGunNobetTakipGrupAltGrup ayniGunNobetTakipGrupAltG);
        void Update(AyniGunNobetTakipGrupAltGrup ayniGunNobetTakipGrupAltG);
        void Delete(int ayniGunNobetTakipGrupAltGrupId);
        AyniGunNobetTakipGrupAltGrupDetay GetDetayById(int ayniGunNobetTakipGrupAltGId);
        List<AyniGunNobetTakipGrupAltGrupDetay> GetDetaylar();
        List<AyniGunNobetTakipGrupAltGrupDetay> GetDetaylar(int nobetUstGrupId);
        List<AyniGunNobetTakipGrupAltGrupDetay> GetDetaylar(List<int> nobetUstGrupIdList);
    }
}