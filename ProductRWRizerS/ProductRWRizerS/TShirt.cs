using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductRWRizerS
{
    public class TShirt : Apparel
    {
        private string size;

        public TShirt(string desc, string id, double price, int qty, string type, string color, string manufacturer, string material, string size) : base(desc, id, price, qty, type, color, manufacturer, material)
        {
            this.size = size;
        }

        public string Size
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
            }
        }

        public override string GetDisplayText(string separator)
        {
            return base.GetDisplayText(separator) + separator + size;
        }
    }
}
