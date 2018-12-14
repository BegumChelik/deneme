using CoffeeShop.Console.Entity;
using CoffeeShop.Console.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Console.Adapters
{
    class MernisServiceAdapter : IPersonCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {

            MernisServiceReference.KPSPublicSoapClient kPSPublicSoap = new MernisServiceReference.KPSPublicSoapClient();
            return kPSPublicSoap.TCKimlikNoDogrula(Convert.ToInt64(customer.NationalId),customer.FirstName.ToUpper(),customer.SecondName.ToUpper(),customer.BirthDate.Year);
        }
    }


}
