using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductRWRizerS
{
    public class Software : Disk
    {
        private string typeSoft;

        public Software()
        {

        }

        public Software(string desc, string id, double price, int qty, string type, DateTime releaseDate, int numDisks, int size, string typeDisk, string typeSoft) : base(desc, id, price, qty, type, releaseDate, numDisks, size, typeDisk)
        {
            this.typeSoft = typeSoft;
        }

        public string TypeSoft
        {
            get
            {
                return typeSoft;
            }
            set
            {
                typeSoft = value;
            }
        }

        public override string GetDisplayText(string separator)
        {
            return base.GetDisplayText(separator) + separator + typeSoft;
        }
    }
}
