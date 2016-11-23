using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductRWRizerS
{
    public class Music: Entertainment
    {
        private string artist;
        private string genre;
        private string label;
        /*
        public Music()
        {

        }*/

        public Music(string desc, string id, double price, int qty, string type, DateTime releaseDate, int numDisks, int size, string typeDisk, TimeSpan runTime, string artist, string genre, string label) : base(desc, id, price, qty, type, releaseDate, numDisks, size, typeDisk, runTime)
        {
            this.artist = artist;
            this.genre = genre;
            this.label = label;
        }

        public string Artist
        {
            get
            {
                return artist;
            }
            set
            {
                artist = value;
            }
        }

        public string Genre
        {
            get
            {
                return genre;
            }
            set
            {
                genre = value;
            }
        }

        public string Label
        {
            get
            {
                return label;
            }
            set
            {
                label = value;
            }
        }

        public override string GetDisplayText(string separator)
        {
            return base.GetDisplayText(separator) + separator + artist + separator + genre + separator + label;
        }
    }
}
