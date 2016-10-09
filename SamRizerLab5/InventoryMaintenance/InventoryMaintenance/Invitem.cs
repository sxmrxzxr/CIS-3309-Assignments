using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryMaintenance
{
    public class InvItem
    {
        public InvItem()
        {

        }

        public InvItem(int itemNo, string description, decimal price)
        {
            this.ItemNo = itemNo;
            this.Description = description;
            this.Price = price;
        }

        public int ItemNo
        {
            get
            {
                return ItemNo;
            }
            set
            {
                ItemNo = value;
            }
        }

        public string Description
        {
            get
            {
                return Description;
            }
            set
            {
                Description = value;
            }
        }

        public decimal Price
        {
            get
            {
                return Price;
            }
            set
            {
                Price = value;
            }
        }

        public string GetDisplayText()
        {
            return ItemNo + "    " + Description + " (" + Price + ")";
        }
    }
}
