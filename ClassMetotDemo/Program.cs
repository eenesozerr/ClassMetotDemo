using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerMenager customerMenager = new CustomerMenager();
            
            Customer customer1 = new Customer();
            customer1.ID =123456789;
            customer1.Name = "Enes";
            customer1.Surname = "Ozer" ;
            customer1.Balance = 156000;

            Customer customer2 = new Customer();
            customer2.ID = 123456788;
            customer2.Name = "Kerem";
            customer2.Surname = "Karabulut";
            customer2.Balance = 300000;

            Customer customer3 = new Customer();
            customer3.ID = 123456787;
            customer3.Name = "Dogan";
            customer3.Surname = "Ozyurt";
            customer3.Balance = 75000;

            Customer[] customers = new Customer[] { customer1, customer2, customer3 };

            Console.WriteLine("\nCustomer Adding\n*************");
            foreach (var customer in customers)
            {
                
                customerMenager.Add(customer);
                Console.WriteLine("\n-------------------\n");

            }
            Console.WriteLine("\nCustomer Removing\n**************");
            foreach (var customer in customers)
            {

                customerMenager.Remove(customer);
                Console.WriteLine("\n-------------------");

            }



        }
    }
}
