using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductRWRizerS
{
    public class Movie : Entertainment
    {
        private string director;
        private string producer;

        public Movie()
        {

        }

        public Movie(string desc, string id, double price, int qty, string type, DateTime releaseDate, int numDisks, int size, string typeDisk, TimeSpan runTime, string director, string producer) : base(desc, id, price, qty, type, releaseDate, numDisks, size, typeDisk, runTime)
        {
            this.director = director;
            this.producer = producer;
        }

        public string Director
        {
            get
            {
                return director;
            }
            set
            {
                director = value;
            }
        }

        public string Producer
        {
            get
            {
                return producer;
            }
            set
            {
                producer = value;
            }
        }

        public override string GetDisplayText(string separator)
        {
            return base.GetDisplayText() + separator + director + separator + producer;
        }
    }
}
