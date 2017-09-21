using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SportsPro.Models
{
    public class CustomerList
    {
        private List<CustomerItem> customerItems;

        public CustomerList()
        {
            customerItems = new List<CustomerItem>();
        }

        public int Count
        {
            get { return customerItems.Count; }
        }

        public CustomerItem this[int index]
        {
            get { return customerItems[index]; }
            set { customerItems[index] = value; }
        }
        public CustomerItem this[string id]
        {
            get
            {
                foreach (CustomerItem c in customerItems)
                    if (c.Customer.CustomerID == id) return c;
                return null;
            }
        }

        public static CustomerList GetCustomers()
        {
            CustomerList cList = (CustomerList)HttpContext.Current.Session["ContactDisplay"];
            if (cList == null)
                HttpContext.Current.Session["ContactDisplay"] = new CustomerList();
            return (CustomerList)HttpContext.Current.Session["ContactDisplay"];
        }

        public void AddItem(Customer customer)
        {
            CustomerItem c = new CustomerItem();
            customerItems.Add(c);
        }

        public void RemoveAt(int index)
        {
            customerItems.RemoveAt(index);
        }

        public void Clear()
        {
            customerItems.Clear();
        }
    }
}