using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ProductTask.Class
{
    public class Book : Product
    {
        public Book(int id, string name, double price, string genre) : base(id, name, price)
        {
            Genre = genre;
            
        }
        public string Genre {  get; set; }
      
    }
}
