using CoffeeShop.Console.Entity;
using CoffeeShop.Console.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Console.Manager
{
   public class StarbucksCustomerManager:BaseCustomerManager
    {
        public IPersonCheckService _checkCustomerService;
        public StarbucksCustomerManager(IPersonCheckService checkCustomerService)
        {
            _checkCustomerService = checkCustomerService;
        }

        public override void Save(Customer customer)
        {
            if (_checkCustomerService.CheckIfRealPerson(customer))
            {
                base.Save(customer);
            }
            else
            {
                throw new Exception("Not a Valid Exception");
            }
           
        }

        public override void SellCoffeee(Customer customer)
        {
            base.SellCoffeee(customer);
            customer.StarCount++;
        }
    }
}
