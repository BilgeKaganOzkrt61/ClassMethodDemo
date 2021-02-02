using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 661;
            customer1.Name = "Bilge Kağan";
            customer1.Surname = "Özkurt";
            customer1.CustomerBudget = 1579.72;

            Customer customer2 = new Customer();
            customer2.Id = 543;
            customer2.Name = "Ömer";
            customer2.Surname = "Özkurt";
            customer2.CustomerBudget = 847.61;

            Customer customer3 = new Customer();
            customer3.Id = 891;
            customer3.Name = "Betül";
            customer3.Surname = "Boz";
            customer3.CustomerBudget = 7698.15;

            Customer Newcustomer = new Customer();
            Newcustomer.Id = 143;
            Newcustomer.Name = "Yusuf Taha";
            Newcustomer.Surname = "Çebi";
            Newcustomer.CustomerBudget = 411.43;

            Customer[] customers = new Customer[] { customer1, customer2, customer3 };

            foreach (var customer in customers)
            {
                Console.WriteLine(customer.Id);
                Console.WriteLine(customer.Name);
                Console.WriteLine(customer.Surname);
                Console.WriteLine(customer.CustomerBudget);
                Console.WriteLine("--------------------");

                
            }
            CustomerManager customerManager = new CustomerManager();

            customerManager.Create(Newcustomer);

            customerManager.Removed(customer3);

            Console.WriteLine("Customers Listed ");

            customerManager.CustomerList(customer1);
            customerManager.CustomerList(customer2);
            customerManager.CustomerList(Newcustomer);


        }
    }
}
