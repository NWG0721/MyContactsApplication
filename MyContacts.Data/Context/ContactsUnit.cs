using MyContacts.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyContacts.Data.Service;

namespace MyContacts.Data.Context
{
    public class ContactsUnit:IDisposable
    {
        MyContacts_DBEntities db = new MyContacts_DBEntities();

        private IContactsRepository _contacRepository;

        public IContactsRepository ContactsRepository
        {
            get
            {
                if (_contacRepository == null)
                {
                    _contacRepository = new ContactsRepository(db);
                }
                return _contacRepository;
            }
        }

        public void Dispose()
        {
            db.Dispose();
        }
    }
}
