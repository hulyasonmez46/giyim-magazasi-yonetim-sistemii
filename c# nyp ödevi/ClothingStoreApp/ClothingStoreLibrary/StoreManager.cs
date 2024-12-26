using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingStoreLibrary
{
    //Mağaza yönetimi sınıfı
    public class StoreManager
    {
        public List<Item> Inventory { get; private set; } = new List<Item>();
        public List<Order> Orders { get; private set; } = new List<Order>();

        public void AddItemToInventory(Item item)
        {
            Inventory.Add(item);
        }

        public void ListInventory()
        {
            foreach (var item in Inventory)
            {
                Console.WriteLine(item.GetDetails());
            }
        }

        public Item SearchItem(int itemId)
        {
            return Inventory.FirstOrDefault(item => item.ItemId == itemId);
        }

        public void PlaceOrder(Order order)
        {
            Orders.Add(order);
        }

        public void ListOrders()
        {
            foreach (var order in Orders)
            {
                Console.WriteLine(order.GetOrderSummary());
            }
        }
    }
}
