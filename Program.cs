using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Category> MehsulKategoriyasi = new List<Category>();
            MehsulKategoriyasi.Add(new Category(1, "Notebook", "N.jpg"));
            MehsulKategoriyasi.Add(new Category(2, "PC", "PC.jpg"));
            MehsulKategoriyasi.Add(new Category(3, "YumsakMebel", "YM.jpg"));
            MehsulKategoriyasi.Add(new Category(4, "MeisehTexnikasi", "MT.jpg"));
            MehsulKategoriyasi.Add(new Category(5, "Klavratura", "K.jpg"));
            // MehsulKategoriyasi.Add(new Category(6, "", ""));


            List<Product> Product = new List<Product>();
            Product.Add(new Product("HP", 0124521, 1, MehsulKategoriyasi[0]));
            Product.Add(new Product("Acer", 0123521, 2, MehsulKategoriyasi[1]));
            Product.Add(new Product("SamsungTV", 24568555, 3, MehsulKategoriyasi[3]));
            Product.Add(new Product("YatasDivan", 0128748456, 4, MehsulKategoriyasi[2]));
            Product.Add(new Product("Acer", 0123521, 5, MehsulKategoriyasi[4]));
            Product.Add(new Product("Beko Soyuducu", 545646464, 6, MehsulKategoriyasi[3]));



            List<Nomeklatur> Yasamal = new List<Nomeklatur>();
            Yasamal.Add(new Nomeklatur(Product[0], 252, "AZM", DateTime.Now, 3));
            Yasamal.Add(new Nomeklatur(Product[1], 1550, "AZM", DateTime.Now, 1));
            Yasamal.Add(new Nomeklatur(Product[2], 2525, "AZM", DateTime.Now, 1));
            Yasamal.Add(new Nomeklatur(Product[3], 5010, "AZM", DateTime.Now, 5));
            Yasamal.Add(new Nomeklatur(Product[4], 5, "AZM", DateTime.Now, 2));
            Yasamal.Add(new Nomeklatur(Product[5], 1300, "AZM", DateTime.Now, 6));

            //foreach (var e in MehsulKategoriyasi)
            //    Console.WriteLine(e.getInfo() + "Umumi mehsul sayi:" + say(e.ID));
            Console.WriteLine("Adinizi daxil edin");
            string IstifadeciAdi = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Xos geldin {0} ",IstifadeciAdi);
            Console.WriteLine();
            Console.WriteLine("Zehmet olmasa asagidakilardan birini secin:");
            Console.WriteLine("1. Satis etmek \n2. Mehsul elave etmek");
            int secim = startSecim();
            if (secim == 1)
            {
                while (true)
                {
                    foreach (var e in MehsulKategoriyasi)
                        Console.WriteLine(e.getInfo() + "Umumi mehsul sayi:" + say(e.ID));
                    Console.WriteLine();
                    Console.WriteLine("Zehmet olmasa satis etmek ucun kateqoriyanin ID-sini secin");
                    int catID = Int32.Parse(Console.ReadLine());
                    var products = Yasamal.Where(w => w.Product.Category.ID == catID);
                    foreach (var e in products)
                        Console.WriteLine(e.getInfo());
                    Console.WriteLine();
                    Console.WriteLine("ZEhmet olmasa mehsulun ID-sini secin:");
                    int ProductID = Int32.Parse(Console.ReadLine());
                    var sellProduct = Yasamal.FirstOrDefault(y => y.Product.ID == ProductID);
                    sellProduct.Count = sellProduct.Count - 1;
                }

            }
            else
            {
                Console.WriteLine();
            }











            int say(int id)
            {
                return Yasamal.Where(y => y.Product.Category.ID == id).GroupBy(g => g.Product.Category.ID).Select(s => s.Sum(g => g.Count)).First();
            }

            int startSecim()
            {
                try { return Int32.Parse(Console.ReadLine()); }
                catch
                {
                    Console.WriteLine("Zehmet olamsa reqem daxil edin");
                    return startSecim();
                }
            }
           
        }
    }
}
