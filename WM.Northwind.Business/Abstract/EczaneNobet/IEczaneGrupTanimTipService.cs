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
    public interface IEczaneGrupTanimTipService
    {
        EczaneGrupTanimTip GetById(int eczaneGrupTanimTipId);
        List<EczaneGrupTanimTip> GetList();
        //List<EczaneGrupTanimTip> GetByCategory(int categoryId);
        void Insert(EczaneGrupTanimTip eczaneGrupTanimTip);
        void Update(EczaneGrupTanimTip eczaneGrupTanimTip);
        void Delete(int eczaneGrupTanimTipId);
        List<EczaneGrupTanimTip> GetList(List<int> eczaneGrupTanimTipIdList);
    }
}