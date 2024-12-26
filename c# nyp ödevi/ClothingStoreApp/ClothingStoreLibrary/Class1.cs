
using System;
using System.Collections.Generic;
using System.Linq;

namespace ClothingStoreLibrary
{
    // Elemanın temel sınıfı
    public class Item
    {
        public int ItemId { get; set; }
        public string Name { get; set; }
        public string Size { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
        public bool InStock { get; set; }

      

        public virtual string GetDetails()
        {
            return $"ID: {ItemId}, Name: {Name}, Size: {Size}, Category: {Category}, Price: {Price}, In Stock: {InStock}";
        }
    }
}
