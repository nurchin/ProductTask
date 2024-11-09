using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductTask.Class
{
    internal class Product
    {
        public string Name { get; set; }
        public int Id { get; set; }

        private double _price;
        private int _count;
        private int id;

        public double Price {
            get { 
                return _price;
            }
            set
            {
                if (value > 0)
                {
                    _price = value;

                }
            }
        
        }

        public int Count {
            get
            {
                return _count;
            }
            set
            {
                if (value > 0)
                {
                    _count = value;
                }
            }
        }

     

        public Product(int id, string name, double price)
        {
            this.id = id;
            Name = name;
            Price = price;
        }
    }
}
