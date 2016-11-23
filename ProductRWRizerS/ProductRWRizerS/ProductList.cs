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

        public new void AddProduct(Product p)
        {
            this.Add(p);
        }

        public void readFromFile(string filename) 
        {
            try
            {
                StreamReader read = new StreamReader(File.OpenRead(filename));

                while (!read.EndOfStream)
                {
                    string line = read.ReadLine();
                    string[] values = line.Split(',');

                    switch (values[0])
                    {
                        case "DressShirt":
                            this.AddProduct(new DressShirt(values[0], values[1], Convert.ToDouble(values[2]), Convert.ToInt32(values[3]), values[4], values[5], values[6], values[7], Convert.ToInt32(values[8]), Convert.ToInt32(values[9])));
                            break;
                        case "Pants":
                            this.AddProduct(new Pants(values[0], values[1], Convert.ToDouble(values[2]), Convert.ToInt32(values[3]), values[4], values[5], values[6], values[7], Convert.ToInt32(values[8]), Convert.ToInt32(values[9])));
                            break;
                        case "TShirt":
                            this.AddProduct(new TShirt(values[0], values[1], Convert.ToDouble(values[2]), Convert.ToInt32(values[3]), values[4], values[5], values[6], values[7], values[8]));
                            break;
                        case "Software":
                            this.AddProduct(new Software(values[0], values[1], Convert.ToDouble(values[2]), Convert.ToInt32(values[3]), values[4], Convert.ToDateTime(values[5]), Convert.ToInt32(values[6]), Convert.ToInt32(values[7]), values[8], values[9]));
                            break;
                        case "Movie":
                            this.AddProduct(new Movie(values[0], values[1], Convert.ToDouble(values[2]), Convert.ToInt32(values[3]), values[4], Convert.ToDateTime(values[5]), Convert.ToInt32(values[6]), Convert.ToInt32(values[7]), values[8], TimeSpan.Parse(values[9]), values[10], values[11]));
                            break;
                        case "Music":
                            this.AddProduct(new Music(values[0], values[1], Convert.ToDouble(values[2]), Convert.ToInt32(values[3]), values[4], Convert.ToDateTime(values[5]), Convert.ToInt32(values[6]), Convert.ToInt32(values[7]), values[8], TimeSpan.Parse(values[9]), values[10], values[11], values[12]));
                            break;
                    }
                }
            }
            catch (FileNotFoundException f)
            {
                
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
            StreamWriter writer = new StreamWriter(@"Output.csv");

            foreach (Product p in this)
            {
                writer.WriteLine(p.ToCSV());              
            }            
        }

        public void writeToBinary()
        {
            BinaryWriter bOut = new BinaryWriter(new FileStream(@"Products.dat", FileMode.Create, FileAccess.Write));

            foreach (Product p in this)
            {
                bOut.Write(p.Desc);
                bOut.Write(p.ID);
                bOut.Write(p.Price);
                bOut.Write(p.Quantity);
                bOut.Write(p.Type);

                switch (p.Desc)
                {
                    case "DressShirt":
                        DressShirt d = (DressShirt)p;
                        bOut.Write(d.Color);
                        bOut.Write(d.Manufacturer);
                        bOut.Write(d.Material);
                        bOut.Write(d.Neck);
                        bOut.Write(d.Sleeve);
                        break;
                    case "Pants":
                        Pants x = (Pants)p;
                        bOut.Write(x.Color);
                        bOut.Write(x.Manufacturer);
                        bOut.Write(x.Material);
                        bOut.Write(x.Inseam);
                        bOut.Write(x.Waist);
                        break;
                    case "TShirt":
                        TShirt t = (TShirt)p;
                        bOut.Write(t.Color);
                        bOut.Write(t.Manufacturer);
                        bOut.Write(t.Material);
                        bOut.Write(t.Size);
                        break;
                    case "Software":
                        Software s = (Software)p;
                        bOut.Write(s.ReleaseDate.ToString());
                        bOut.Write(s.NumDisks);
                        bOut.Write(s.Size);
                        bOut.Write(s.TypeDisk);
                        bOut.Write(s.TypeSoft);
                        break;
                    case "Movie":
                        Movie m = (Movie)p;
                        bOut.Write(m.ReleaseDate.ToString());
                        bOut.Write(m.NumDisks);
                        bOut.Write(m.Size);
                        bOut.Write(m.TypeDisk);
                        bOut.Write(m.RunTime.ToString());
                        bOut.Write(m.Director);
                        bOut.Write(m.Producer);
                        break;
                    case "Music":
                        Music u = (Music)p;
                        bOut.Write(u.ReleaseDate.ToString());
                        bOut.Write(u.NumDisks);
                        bOut.Write(u.Size);
                        bOut.Write(u.TypeDisk);
                        bOut.Write(u.RunTime.ToString());
                        bOut.Write(u.Artist);
                        bOut.Write(u.Genre);
                        bOut.Write(u.Label);
                        break;
                }
            }
        }
    }
    
}
