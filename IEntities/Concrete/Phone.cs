using IEntities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace IEntities.Concrete
{
   public  class Phone :IEntity
    {
        public int PhoneId { get; set; }
        public string PhoneName { get; set; }

        public decimal UnitPrice { get; set; }

        public short UnitsInStock { get; set; }

        public string Description { get; set; }
        public string ModelYear { get; set; }

    }
}
