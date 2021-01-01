using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    struct Address
    {
        private byte HouseNumber;
        private string RoadNumber ;
        private ushort PostalCode ;
        private string district ;

        public Address(byte a, String b, ushort c, string d)
        {
            this.HouseNumber = a;
            this.RoadNumber = b;
            this.PostalCode = c;
            this.district = d;
            a = 42;
            b = "Bhojohori Shaha Street";
            c = 1100;
            d = "Dhaka";
        }

    }
}
