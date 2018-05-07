using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abc
{
    class Phone
    {
        protected string phoneName;
        protected string phoneType;
        protected float phonePrice;

        public string PhoneName
        {
            get { return phoneName; }
            set { phoneName = value; }
        }

        public string PhoneType
        {
            get { return phoneType; }
            set { phoneType = value; }
        }

        public float PhonePrice
        {
            get { return phonePrice; }
            set { phonePrice = value; }
        }
        public Phone()
        {
        }

        public string Display()
        {
            return string.Format("Phone {0}, type {1}, price {2}.", phoneName, phoneType, phonePrice);
        }
    }
}
