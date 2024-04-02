using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace _240401_1.models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string EmailAddress { get; set; }
        public string HomeAddress { get; set; }
        public string WorkAddress { get; set; }
        
        public Customer()
        {

        }

        public Customer(int id)
        {
            CustomerId = id;
        }

        public bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(Name)) isValid = false;
            return isValid;
        }

        public Customer Retrieve(int costumerId)
        {
            return new Customer();
        }

        public List<Customer> Retriever()
        {
            return new List<Customer>();
        }

        public void Save(Customer customer)
        {

        }

    }
}