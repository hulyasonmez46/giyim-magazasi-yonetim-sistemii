using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingStoreLibrary
{
    // Sipariş kategorisi
    public class Order
    {
        public int OrderId { get; set; }
        public Customer Customer { get; set; }
        public List<Item> Items { get; private set; } = new List<Item>();

        public decimal TotalPrice => Items.Sum(item => item.Price);

        public void AddItem(Item item)
        {
            Items.Add(item);
        }

        public void RemoveItem(Item item)
        {
            Items.Remove(item);
        }

        public string GetOrderSummary()
        {
            return $"Order ID: {OrderId}, Customer: {Customer.Name}, Total Price: {TotalPrice}";
        }
    }
}
