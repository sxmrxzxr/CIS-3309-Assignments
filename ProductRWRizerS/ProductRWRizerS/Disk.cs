using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductRWRizerS
{
    public class Disk : Media
    {
        private int numDisks;
        private int size;
        private string typeDisk;

        public Disk()
        {

        }

        public Disk(string desc, string id, double price, int qty, string type, DateTime releaseDate, int numDisks, int size, string typeDisk) : base(desc, id, price, qty, type, releaseDate)
        {
            this.numDisks = numDisks;
            this.size = size;
            this.typeDisk = typeDisk;
        }

        public int NumDisks
        {
            get
            {
                return numDisks;
            }
            set
            {
                numDisks = value;
            }
        }

        public int Size
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

        public string TypeDisk
        {
            get
            {
                return typeDisk;
            }
            set
            {
                typeDisk = value;
            }
        }

        public override string GetDisplayText(string separator)
        {
            return base.GetDisplayText(separator) + separator + numDisks + separator + size + separator + typeDisk;
        }
    }
}
