﻿    using System;
using EntityLayer.Concrete;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstrack
{
    public interface IAnnoncementService : IGenericService<Annoncement>
    {
        void AnnoncementStatusToTrue(int id);
        void AnnoncementStatusToFalse(int id);
    }
}
