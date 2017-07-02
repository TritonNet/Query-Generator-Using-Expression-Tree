using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DEMO.Entity
{
    public class Customer
    {
        public string ID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public string Email { get; set; }

        public string MobileNo { get; set; }

        public Address CustomerAddress { get; set; }
    }
}
