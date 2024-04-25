using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyContacts.Data.Repository
{
    public interface IContactsRepository
    {
        List<Contact> Selecet();

        List<Contact> SelecetByFillter(string parameter);

        Contact SelectById(int id);

        bool Insert(Contact contact);

        bool Update(Contact contact);

        bool Delete(Contact contact);

        bool DeleteByRow(int id);

        void Save();
    }
}
