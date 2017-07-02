using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DEMO.Entity;
using System.Linq.Expressions;

namespace DEMO.DataAccess
{
    public class CustomerService
    {
        public CustomerService()
        {
           
        }

        public void Select(dynamic customerProp)
        {
            var properties = typeof(customerProp).GetProperties().ToList();
        }
        

    }
}
