using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Create(Customer customer)
        {
            Console.WriteLine("Customer Created --> " + customer.Id + " : " + customer.Name + " " 
                + customer.Surname + " : " + customer.CustomerBudget);
        }
        public void Removed (Customer customer)
        {
            Console.WriteLine("Customer Removed --> " + customer.Id + " : " + customer.Name + " " +
                 customer.Surname + " : "   + customer.CustomerBudget);
        }
        public void CustomerList (Customer customer)
        {
            
            Console.WriteLine("------------------");
            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);
            Console.WriteLine(customer.Surname);
            Console.WriteLine(customer.CustomerBudget);



        }

    }

}

