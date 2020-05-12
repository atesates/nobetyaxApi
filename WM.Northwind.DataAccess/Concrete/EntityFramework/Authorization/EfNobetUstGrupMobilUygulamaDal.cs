using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using WM.Core.DAL.EntityFramework;
using WM.Northwind.DataAccess.Abstract.Authorization;
using WM.Northwind.DataAccess.Concrete.EntityFramework.Contexts;
using WM.Northwind.Entities.ComplexTypes.EczaneNobet;
using WM.Northwind.Entities.Concrete.Authorization;

namespace WM.Northwind.DataAccess.Concrete.EntityFramework.Authorization
{
    public class EfNobetUstGrupMobilUygulamaDal : EfEntityRepositoryBase<NobetUstGrupMobilUygulama, EczaneNobetContext>, INobetUstGrupMobilUygulamaDal
    {
       
    }
}
