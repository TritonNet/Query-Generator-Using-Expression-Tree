using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DEMO.DataAccess;
using DEMO.Entity;
using Peercore.IngresLinq;

namespace DEMO.BusinessLogic
{
    public class CompanyService
    {
        public CompanyService()
        {
            var customers = new Customers();
            var sss = customers.PSelect(C => new
            {
                C.Age,
                C.CustomerAddress,
            }).ToList();
            
            
        }
    }
}
