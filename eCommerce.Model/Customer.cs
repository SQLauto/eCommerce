using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Model
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }

        public string Address1 { get; set; }
        public string City { get; set; }
        public string PostCode { get; set; }

        //Add First Name, Last Name, Suburb, Phone, Mobile once basic functionailty has been created
    }
}
