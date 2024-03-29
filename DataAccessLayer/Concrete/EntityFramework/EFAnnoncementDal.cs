﻿using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repository;
using DataAccessLayer.Context;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataAccessLayer.Concrete.EntityFramework
{
    public class EFAnnoncementDal : GenericRepository<Annoncement>, IAnnoncementDal
    {
        public void AnnoncementStatusToFalse(int id)
        {
            using var context = new AgContext();
            Annoncement p = context.Annoncements.Find(id);
            p.Status = false;
            context.SaveChanges();
        }

        public void AnnoncementStatusToTrue(int id)
        {
            using var context = new AgContext();
            Annoncement p = context.Annoncements.Find(id);
            p.Status = true;
            context.SaveChanges();
        }
    }
}
