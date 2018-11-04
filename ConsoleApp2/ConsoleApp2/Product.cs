using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Product
    {
        public string Name { get; set; }
        public int Barcode { get; set; }
        public int ID { get; set; }
        public Category Category { get; set; }

        public Product(string name, int barcode, int id, Category c)
        {
            Name = name;
            Barcode = barcode;
            ID = id;
            Category = c;
        }

        public string getInfo()
        {
            string s = String.Format("ID: {0}  Adi: {1}   Barcodu: {2} Kategoriya: {3} ",ID,Name, Barcode, Category.Name);
            return s;
        }
    }
}
