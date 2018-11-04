using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Category
    {
        public int ID;
        public string Name;
        public string Photo;

       public Category(int id, string adi, string photo)
        {
            ID = id;
            Name = adi;
            Photo = photo;

        }

        public string getInfo ()
        {
            string s = String.Format("ID: {0}  Kategoriya : {1}, Photo: {2} ", ID,Name,Photo);
            return s;
        }
    }
}
