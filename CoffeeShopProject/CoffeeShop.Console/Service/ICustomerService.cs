using CoffeeShop.Console.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Console.Service
{
    public interface ICustomerService
    {
        void Save(Customer customer);

        void SellCoffeee(Customer customer);
    }
}
