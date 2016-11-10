﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductRWRizerS
{
    public class Product
    {
        public string desc;
        public string id;
        public double price;
        public int qty;
        public string type;

        public Product(string desc, string id, double price, int qty, string type)
        {
            this.desc = desc;
            this.id = id;
            this.price = price;
            this.qty = qty;
            this.type = type;
        }

        public string Desc
        {
            get
            {
                return desc;
            }
            set
            {
                desc = value;
            }
        }

        public string ID
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }

        public int Quantity
        {
            get
            {
                return qty;
            }
            set
            {
                qty = value;
            }
        }

        public string Type
        {
            get
            {
                return type;
            }
            set
            {
                type = value;
            }
        }

        public string GetDisplayText()
        {

        }
    }
}