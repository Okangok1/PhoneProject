using IEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
   public interface IPhoneDal
    {
        List<Phone> GetAll();

        void Add(Phone phone);

        void Delete(Phone phone);
        void Update(Phone phone);

    }
}
