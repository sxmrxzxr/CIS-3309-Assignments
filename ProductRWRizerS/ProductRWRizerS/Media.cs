using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductRWRizerS
{
    public class Media : Product
    {
        private DateTime releaseDate;

        /*
        public Media()
        {

        }*/

        public Media(string desc, string id, double price, int qty, string type, DateTime releaseDate) : base(desc, id, price, qty, type)
        {
            this.releaseDate = releaseDate;
        }

        public DateTime ReleaseDate
        {
            get
            {
                return releaseDate;
            }
            set
            {
                releaseDate = value;
            }
        }

        public override string GetDisplayText(string separator)
        {
            return base.GetDisplayText(separator) + separator + releaseDate.ToShortDateString();
        }
    }
}
