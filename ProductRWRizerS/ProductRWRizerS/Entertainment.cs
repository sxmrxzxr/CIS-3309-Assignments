using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductRWRizerS
{
    public class Entertainment : Disk
    {
        private TimeSpan runTime;

        public Entertainment()
        {

        }

        public Entertainment(string desc, string id, double price, int qty, string type, DateTime releaseDate, int numDisks, int size, string typeDisk, TimeSpan runTime) : base(desc, id, price, qty, type, releaseDate, numDisks, size, typeDisk)
        {
            this.runTime = runTime;
        }

        public TimeSpan RunTime
        {
            get
            {
                return runTime;
            }
            set
            {
                runTime = value;
            }
        }

        public override string GetDisplayText(string separator)
        {
            return base.GetDisplayText() + separator + runTime.ToString();
        }
    }
}
