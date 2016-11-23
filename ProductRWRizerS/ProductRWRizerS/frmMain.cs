using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductRWRizerS
{
    public partial class frmMain : Form
    {
        ProductList l = new ProductList();
        int idx = 0;

        public frmMain()
        {
            InitializeComponent();
            btnWrite.Enabled = false;
        }

        public void drawSet(bool var1, bool var2, bool var3, bool var4, bool var5, bool var6, bool var7, bool var8)
        {
            lblVar1.Visible = var1;
            txtVar1.Visible = var1;

            lblVar2.Visible = var2;
            txtVar2.Visible = var2;

            lblVar3.Visible = var3;
            txtVar3.Visible = var3;

            lblVar4.Visible = var4;
            txtVar4.Visible = var4;

            lblVar5.Visible = var5;
            txtVar5.Visible = var5;

            lblVar6.Visible = var6;
            txtVar6.Visible = var6;

            lblVar7.Visible = var7;
            txtVar7.Visible = var7;

            lblVar8.Visible = var8;
            txtVar8.Visible = var8;
        }

        public void drawApparel(Product p)
        {
            Apparel a = (Apparel)p;

            lblVar1.Text = "Color";
            txtVar1.Text = a.Color;

            lblVar2.Text = "Manufacturer";
            txtVar2.Text = a.Manufacturer;

            lblVar3.Text = "Material";
            txtVar3.Text = a.Material;
        }

        public void drawMedia(Product p)
        {
            Media m = (Media)p;

            lblVar1.Text = "Release Date";
            txtVar1.Text = m.ReleaseDate.ToString();
        }

        public void drawDisk(Product p)
        {
            Disk d = (Disk)p;
            drawMedia(p);

            lblVar2.Text = "Num Disks";
            txtVar2.Text = d.NumDisks.ToString();

            lblVar3.Text = "Size";
            txtVar3.Text = d.Size.ToString();

            lblVar4.Text = "Type Disk";
            txtVar4.Text = d.TypeDisk;
        }

        public void drawEntertainment(Product p)
        {
            Entertainment e = (Entertainment)p;
            drawDisk(p);

            lblVar5.Text = "Run Time";
            txtVar5.Text = e.RunTime.ToString();
        }

        public void drawBook(Product p)
        {
            Book b = (Book)p;

            drawSet(true, true, true, true, false, false, false, false);
            drawMedia(p);

            lblVar2.Text = "Author";
            txtVar2.Text = b.Author;

            lblVar3.Text = "Pages";
            txtVar3.Text = b.NumPages.ToString();

            lblVar4.Text = "Publisher";
            txtVar4.Text = b.Publisher;
        }

        public void drawDressShirt(Product p)
        {
            DressShirt d = (DressShirt)p;

            drawSet(true, true, true, true, true, false, false, false);
            drawApparel(p);

            lblVar4.Text = "Neck";
            txtVar4.Text = d.Neck.ToString();

            lblVar5.Text = "Sleeve";
            txtVar5.Text = d.Sleeve.ToString();
        }

        public void drawPants(Product p)
        {
            Pants s = (Pants)p;

            drawSet(true, true, true, true, true, false, false, false);
            drawApparel(p);

            lblVar4.Text = "Inseam";
            txtVar4.Text = s.Inseam.ToString();

            lblVar5.Text = "Waist";
            txtVar5.Text = s.Waist.ToString();
        }

        public void drawTShirt(Product p)
        {
            TShirt t = (TShirt)p;

            drawSet(true, true, true, true, false, false, false, false);
            drawApparel(p);

            lblVar4.Text = "Size";
            txtVar4.Text = t.Size.ToString();
        }

        public void drawSoftware(Product p)
        {
            Software s = (Software)p;

            drawSet(true, true, true, true, true, false, false, false);
            drawDisk(p);

            lblVar5.Text = "Type Soft";
            txtVar5.Text = s.TypeSoft;
        }

        public void drawMovie(Product p)
        {
            Movie m = (Movie)p;

            drawSet(true, true, true, true, true, true, true, false);
            drawEntertainment(p);

            lblVar6.Text = "Director";
            txtVar6.Text = m.Director;

            lblVar7.Text = "Producer";
            txtVar7.Text = m.Producer;
        }

        public void drawMusic(Product p)
        {
            Music m = (Music)p;

            drawSet(true, true, true, true, true, true, true, true);
            drawEntertainment(p);

            lblVar6.Text = "Artist";
            txtVar6.Text = m.Artist;

            lblVar7.Text = "Genre";
            txtVar7.Text = m.Genre;

            lblVar8.Text = "Label";
            txtVar8.Text = m.Label;
        }

        public void drawProduct()
        {
                Product p = l.ElementAt(idx);
                txtType.Text = p.Type;
                txtID.Text = p.ID;
                txtDesc.Text = p.Desc;
                txtPrice.Text = p.Price.ToString("C");
                txtQuantity.Text = p.Quantity.ToString();
                if (p.Desc == "Book")
                    drawBook(p);
                else if (p.Desc == "Software")
                    drawSoftware(p);
                else if (p.Desc == "Music")
                    drawMusic(p);
                else if (p.Desc == "Movie")
                    drawMovie(p);
                else if (p.Desc == "Pants")
                    drawPants(p);
                else if (p.Desc == "TShirt")
                    drawTShirt(p);
                else if (p.Desc == "DressShirt")
                    drawDressShirt(p);
                else
                    MessageBox.Show("Not found.");
            
        }


        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            l.readFromFile(@"C:/Users/telec/Documents/Visual Studio 2015/Projects/CIS-3309-Assignments/ProductRWRizerS/Products.csv");
            drawProduct();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {           
            if (idx > l.Count)
            {
                idx = 0;
            } else
            {
                idx++;
            }

            drawProduct();
        }
    }
}
