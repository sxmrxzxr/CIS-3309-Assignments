using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductRWRizerS
{
    public class Pants : Apparel
    {
        private int inseam;
        private int waist;

        public Pants(string desc, string id, double price, int qty, string type, string color, string manufacturer, string material, int inseam, int waist) : base(desc, id, price, qty, type, color, manufacturer, material)
        {
            this.inseam = inseam;
            this.waist = waist;
        }

        public int Inseam
        {
            get
            {
                return inseam;
            }
            set
            {
                inseam = value;
            }
        }

        public int Waist
        {
            get
            {
                return waist;
            }
            set
            {
                waist = value;
            }
        }

        public override string GetDisplayText(string separator)
        {
            return base.GetDisplayText(separator) + separator + inseam + separator + waist;
        }
    }
}
