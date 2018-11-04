using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Nomeklatur
    {
        public Product Product { get; set; }
        public double Price { get; set; }
        public string Valyuta { get; set; }
        public DateTime Date { get; set; }
        public int Count { get; set; }

        public Nomeklatur (Product product, double price,string valyuta, DateTime date,int count)
        {
            Product = product;
            Price = price;
            Valyuta = valyuta;
            Date = date;
            Count = count;
        }

        public string getInfo()
        {
            string s = String.Format("ID: {0}  Meshsulun adi: {1}  |  Qiymeti: {2}  |  Valuta novu: {3}  |  Daxil olma Tarixi {4}  | Sayi: {5} " ,Product.ID,Product.Name, Price, Valyuta,Date ,Count);
            return s;
        }

    }
}
