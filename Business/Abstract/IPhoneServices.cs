using IEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IPhoneServices
    {
        List<Phone> GetAll();
    }
}
