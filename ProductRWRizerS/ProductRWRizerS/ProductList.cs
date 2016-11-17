using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductRWRizerS;
using System.IO;

namespace ProductRWRizerS
{
    public class ProductList : List<Product>
    {
        public ProductList()
        {

        }

        public new void Add(Product p)
        {
            this.Add(p);
        }

        public void readFromFile(string filename)
        {
            StreamReader read = new StreamReader(File.OpenRead(@"Products.csv"));

            while (!read.EndOfStream)
            {
                string line = read.ReadLine();
                string[] values = line.Split(',');

                switch (values[0])
                {
                    case "DressShirt":
                        this.Add(new DressShirt(values[0], values[1], Convert.ToDouble(values[2]), Convert.ToInt32(values[3]), values[4], values[5], values[6], values[7], Convert.ToInt32(values[8]), Convert.ToInt32(values[9])));
                        break;
                    case "Pants":
                        this.Add(new Pants(values[0], values[1], Convert.ToDouble(values[2]), Convert.ToInt32(values[3]), values[4], values[5], values[6], values[7], Convert.ToInt32(values[8]), Convert.ToInt32(values[9])));
                        break;
                    case "TShirt":
                        this.Add(new TShirt(values[0], values[1], Convert.ToDouble(values[2]), Convert.ToInt32(values[3]), values[4], values[5], values[6], values[7], values[8]));
                        break;
                    case "Software":
                        this.Add(new Software(values[0], values[1], Convert.ToDouble(values[2]), Convert.ToInt32(values[3]), values[4], Convert.ToDateTime(values[5]), Convert.ToInt32(values[6]), Convert.ToInt32(values[7]), values[8], values[9]));
                        break;
                    case "Movie":
                        this.Add(new Movie(values[0], values[1], Convert.ToDouble(values[2]), Convert.ToInt32(values[3]), values[4], Convert.ToDateTime(values[5]),Convert.ToInt32(values[6]), Convert.ToInt32(values[7]), values[8], TimeSpan.Parse(values[9]), values[10], values[11]));
                        break;
                    case "Music":
                        this.Add(new Music(values[0], values[1], Convert.ToDouble(values[2]), Convert.ToInt32(values[3]), values[4], Convert.ToDateTime(values[5]), Convert.ToInt32(values[6]), Convert.ToInt32(values[7]), values[8], TimeSpan.Parse(values[9]), values[10], values[11], values[12]));
                        break;
                }
                //this.Add(new )
            }
        }

        public override string ToString()
        {
            string s = "";

            foreach (Product p in this)
            {
                s += p.ToString();
                s += "\r\n";    
            }

            return s;
        }

        public void ToCSV()
        {

        }
    }
    
}
