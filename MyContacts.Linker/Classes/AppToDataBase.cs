using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyContacts.Data.Context;

namespace MyContacts.Linker.Classes
{
    public class AppToDataBase
    {
        ContactsUnit db;
        public bool GetUsresData()
        {
            ContactsUnit db = new ContactsUnit();
            return db.ContactsRepository.Insert();
        }
    }
}
