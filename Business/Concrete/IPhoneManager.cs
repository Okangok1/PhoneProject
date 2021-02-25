using Business.Abstract;
using DataAccess.Abstract;
using IEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class IPhoneManager : IPhoneServices
    {
        IPhoneDal _phoneDal;
        public IPhoneManager(IPhoneDal phoneDal)
        {
            _phoneDal = phoneDal;
        }
        public List<Phone> GetAll()
        {
            return _phoneDal.GetAll();
        }
    }
}
