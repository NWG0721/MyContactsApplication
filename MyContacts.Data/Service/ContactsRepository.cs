using MyContacts.Data.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace MyContacts.Data.Service
{
    public class ContactsRepository : IContactsRepository
    {
        MyContacts_DBEntities db;

        public ContactsRepository(MyContacts_DBEntities context)
        {
            this.db = context;
        }
        public Contact SelectById(int id)
        {
            return db.Contacts.Find(id);
        }
        public List<Contact> Selecet()
        {
            return db.Contacts.ToList();
        }

        public List<Contact> SelecetByFillter(string parameter)
        {
            return db.Contacts.Where(person => person.Person_FullName.Contains(parameter) || person.Person_Email.Contains(parameter)
            || person.Person_Phone.Contains(parameter) || person.Person_Address.Contains(parameter)).ToList();
        }

        public bool Delete(Contact contact)
        {
            try
            {
                db.Entry(contact).State = EntityState.Deleted;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeleteByRow(int id)
        {
            try
            {
                var person = SelectById(id);
                Delete(person);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Insert(Contact contact)
        {
            try
            {
                db.Contacts.Add(contact);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }


        public bool Update(Contact contact)
        {
            try
            {
                db.Entry(contact).State = EntityState.Modified;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}
