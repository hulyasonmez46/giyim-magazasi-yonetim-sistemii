using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingStoreLibrary
{
    //Giysi kategorisi
    public class ClothingItem : Item
    {
        public string Material { get; set; }
        public string Brand { get; set; }

        public override string GetDetails()
        {
            return base.GetDetails() + $", Material: {Material}, Brand: {Brand}";
        }
    }
}
