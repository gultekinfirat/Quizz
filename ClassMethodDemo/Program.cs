using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.CustomerName = "Hakan";
            customer1.CustomerLastName = "Karışık";
            customer1.Gender = "Erkek";
            customer1.Age = 26;
            customer1.Number = "5741236589";
            customer1.City = "İstanbul";
            customer1.Country = "Türkiye";

            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.CustomerName = "Emel";
            customer2.CustomerLastName = "Kaya";
            customer2.Gender = "Kadın";
            customer2.Age = 32;
            customer2.Number = "5463217885";
            customer2.City = "Ankara";
            customer2.Country = "Türkiye";


            // Müşteri eklendi
            CustomerManager customerManager = new CustomerManager();
            
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            Console.WriteLine("--------------------------------------------------");

            // Müşteri listeleme

            customerManager.List(customer1,customer2);

            // Müşteri silme
            customerManager.Delete(customer1);
            customerManager.Delete(customer2);




           Console.ReadLine();

        }
    }
}
