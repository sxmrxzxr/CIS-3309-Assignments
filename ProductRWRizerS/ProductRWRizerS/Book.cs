using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductRWRizerS
{
    public class Book : Media
    {
        private string author;
        private int numPages;
        private string publisher;

        public Book()
        {

        }

        public Book(string desc, string id, double price, int qty, string type, DateTime releaseDate, string author, int numPages, string publisher) : base(desc, id, price, qty, type, releaseDate)
        {
            this.author = author;
            this.numPages = numPages;
            this.publisher = publisher;
        }

        public string Author
        {
            get
            {
                return author;
            }
            set
            {
                author = value;
            }
        }

        public int NumPages
        {
            get
            {
                return numPages;
            }
            set
            {
                numPages = value;
            }
        }

        public string Publisher
        {
            get
            {
                return publisher;
            }
            set
            {
                publisher = value;
            }
        }

        public override string GetDisplayText(string separator)
        {
            return base.GetDisplayText(separator) + separator + author + separator + numPages + separator + publisher;
        }
    }
}
