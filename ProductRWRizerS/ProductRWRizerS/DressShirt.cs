using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductRWRizerS
{
    public class DressShirt : Apparel
    {
        private int neck;
        private int sleeve;

        public DressShirt()
        {

        }

        public DressShirt(string desc, string id, double price, int qty, string type, string color, string manufacturer, string material, int neck, int sleeve) : base(desc, id, price, qty, type, color, manufacturer, material)
        {
            this.neck = neck;
            this.sleeve = sleeve;
        }

        public int Neck
        {
            get
            {
                return neck;
            }
            set
            {
                neck = value;
            }
        }

        public int Sleeve
        {
            get
            {
                return sleeve;
            }
            set
            {
                sleeve = value;
            }
        }

        public override string GetDisplayText(string separator)
        {
            return base.GetDisplayText() + separator + neck + separator + sleeve;
        }
    }
}
