using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SportsPro.Models
{
    public class CustomerItem
    {
        public CustomerItem() { }

        public CustomerItem(Customer customer)
        {
            this.Customer = customer;
        }

        public Customer Customer { get; set; }

        public string Display()
        {
            string displayString = string.Format("{0}, {1}, {2}", Customer.Name, 
                Customer.Phone, 
                Customer.Email);
            return displayString;
        }

    }
}