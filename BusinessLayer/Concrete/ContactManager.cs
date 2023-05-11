using BusinessLayer.Abstrack;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ContactManager : IContactService
    {
        private readonly IContactDal _ContactDal;

        public ContactManager(IContactDal contactDal)
        {
            _ContactDal = contactDal;
        }

        public void Delete(Contact t)
        {
            _ContactDal.Delete(t);
        }

        public Contact GetById(int id)
        {
            return _ContactDal.GetById(id);
        }

        public List<Contact> GetListAll()
        {
            return _ContactDal.GetListAll();
        }

        public void Insert(Contact t)
        {
            _ContactDal.Insert(t);
        }

        public void Update(Contact t)
        {
            throw new NotImplementedException();
        }
    }
}
