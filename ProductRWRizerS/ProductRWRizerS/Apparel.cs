using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductRWRizerS
{
    public class Apparel : Product
    {
        private string color;
        private string manufacturer;
        private string material;

        public Apparel(string desc, string id, double price, int qty, string type, string color, string manufacturer, string material) : base(desc, id, price, qty, type)
        {
            this.color = color;
            this.manufacturer = manufacturer;
            this.material = material;
        }

        public string Color
        {
            get
            {
                return color;
            }
            set
            {
                color = value;
            }
        }

        public string Manufacturer
        {
            get
            {
                return manufacturer;
            }
            set
            {
                manufacturer = value;
            }
        }

        public string Material
        {
            get
            {
                return material;
            }
            set
            {
                material = value;
            }
        }

        public override string GetDisplayText(string separator)
        {
            return base.GetDisplayText() + separator + color + separator + manufacturer + separator + material;
        }
    }
}
