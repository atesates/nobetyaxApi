using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WM.Northwind.Entities.ComplexTypes.EczaneNobet;
using WM.Northwind.Entities.Concrete.Authorization;

namespace WM.Northwind.Business.Abstract.Authorization
{
    public interface INobetUstGrupMobilUygulamaService
    {
        //UserRole GetByUserId(int userRoleId);
        //List<UserRole> GetByRoleId(int roleId);

        NobetUstGrupMobilUygulama GetById(int nobetUstGrupId);
        List<NobetUstGrupMobilUygulama> GetList();
        //List<UserRole> GetByNobetGrup(int nobetId);
        void Insert(NobetUstGrupMobilUygulama nobetUstGrupMobilUygulama);
        void Update(NobetUstGrupMobilUygulama nobetUstGrupMobilUygulama);
        void Delete(int nobetUstGrupMobilUygulamaId);

        List<NobetUstGrupMobilUygulama> GetListByNobetUstGrupId(int nobetUstGrupId);

    }
}
