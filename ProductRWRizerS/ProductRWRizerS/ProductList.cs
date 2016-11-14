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
                var line = read.ReadLine();
                var values = line.Split(',');


                switch (values[0])
                {
                    case "DressShirt":
                        this.Add(new DressShirt(values[0], values[1], Convert.ToDouble(values[2])), Convert.ToInt32(values[3]), values[4], values[5], values[6], values[7], Convert.ToInt32(values[8]), Convert.ToInt32(values[9]));
                }
                //this.Add(new )
            }
        }
    }
    
}
