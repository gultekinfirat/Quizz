using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine(customer.CustomerName + " isimli kişi eklendi.");
        }



        public void List(Customer customer1,Customer customer2)
        {
            Customer[] customers = new Customer[] { customer1, customer2 };
            foreach (Customer customer in customers)
            {
                Console.WriteLine("Ad: " + customer.CustomerName);
                Console.WriteLine("Soyad: " + customer.CustomerLastName);
                Console.WriteLine("Yaş: " + customer.Age);
                Console.WriteLine("Cinsiyet: " + customer.Gender);
                Console.WriteLine("Şehir: " + customer.City);
                Console.WriteLine("Ülke: " + customer.Country);
                Console.WriteLine("------------------------------------------------");

            }

        }

        public void Delete(Customer customer)
        {
            Console.WriteLine(customer.CustomerName + " isimli müşteri silindi: " + "...");
        }



    }
}
