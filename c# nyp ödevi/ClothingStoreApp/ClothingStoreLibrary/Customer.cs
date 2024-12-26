using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingStoreLibrary
{
    //Müşteri sınıfı
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Contact { get; set; }

        public string GetCustomerInfo()
        {
            return $"Customer ID: {CustomerId}, Name: {Name}, Contact: {Contact}";
        }
    }
}
