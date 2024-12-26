using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingStoreLibrary
{
    //Aksesuar kategorisi
    public class AccessoryItem : Item
    {
        public string Color { get; set; }
        public bool IsForMen { get; set; }

        public override string GetDetails()
        {
            return base.GetDetails() + $", Color: {Color}, For Men: {IsForMen}";
        }
    }
}
