using CoffeeShop.Console.Entity;
using CoffeeShop.Console.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Console.Manager
{
    public abstract class BaseCustomerManager : ICustomerService
    {
        public virtual void Save(Customer customer)
        {
            System.Console.WriteLine("Müşteri Kaydedildi." + customer.FirstName + " " + customer.SecondName);
        }

        public virtual void SellCoffeee(Customer customer)
        {
            System.Console.WriteLine("Kahve satıldı " + customer.FirstName + " " + customer.SecondName);

        }
    }
}
