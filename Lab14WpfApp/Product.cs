using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14WpfApp
{
    public enum Category
    {
        Food,
        Appliances
    }

    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Image { get; set; }
        public Category Category { get; set;}

        public override string ToString()
        {
            return Name;
        }
    }    
}
