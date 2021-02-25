using DataAccess.Abstract;
using IEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    
    public class InMemoryPhoneDal : IPhoneDal
    {
        List<Phone> _phone;

        public InMemoryPhoneDal()
        {
            _phone = new List<Phone> { 
            new Phone {PhoneId=1,ModelYear="2019",PhoneName="Realme",Description="4 GB RAM  128GB ROM ",UnitPrice=3600,UnitsInStock=25},
            new Phone {PhoneId=1,ModelYear="2018",PhoneName="Redmi",Description="4 GB RAM  64GB ROM ",UnitPrice=2900,UnitsInStock=50},
            new Phone {PhoneId=1,ModelYear="2019",PhoneName="Huawei",Description="6 GB RAM  128GB ROM ",UnitPrice=4500,UnitsInStock=45},
            new Phone {PhoneId=1,ModelYear="2020",PhoneName="Samsung",Description="4 GB RAM  64GB ROM ",UnitPrice=3200,UnitsInStock=15},
            new Phone {PhoneId=1,ModelYear="2018",PhoneName="Iphone",Description="3 GB RAM  64GB ROM ",UnitPrice=4500,UnitsInStock=5},
            new Phone {PhoneId=1,ModelYear="2020",PhoneName="Xiaomi",Description="8 GB RAM  128GB ROM ",UnitPrice=6000,UnitsInStock=100},
            
            };
        }
        public void Add(Phone phone)
        {
            _phone.Add(phone);
        }

        public void Delete(Phone phone)
        {
            var phoneToDelete = _phone.SingleOrDefault(p=>p.PhoneId==phone.PhoneId);
            _phone.Remove(phoneToDelete);
        }

        public List<Phone> GetAll()
        {
            return _phone;
        }

        public void Update(Phone phone)
        {
            var phoneToUpdate = _phone.SingleOrDefault(p => p.PhoneId == phone.PhoneId);
            phoneToUpdate.PhoneName = phone.PhoneName;
            phoneToUpdate.ModelYear = phone.ModelYear;
            phoneToUpdate.UnitPrice = phone.UnitPrice;
            phoneToUpdate.UnitsInStock = phone.UnitsInStock;
            phoneToUpdate.Description = phone.Description;
           
        }
    }
}
