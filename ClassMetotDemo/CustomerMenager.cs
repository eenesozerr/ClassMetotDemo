using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerMenager
    {
    public void Add(Customer customer)
        {
            Console.WriteLine(customer.ID + "\n" + customer.Name + "\n" + customer.Surname + "\n" + customer.Balance + " Euro\n" + "\nCustomer Added");
        }
    public void Remove(Customer customer) 
        {
            Console.WriteLine(customer.ID +"\n" +  customer.Name + "\n" + customer.Surname + "\n" + customer.Balance + " Euro\n" + "\nCustomer Removed");
        }

    }
}
