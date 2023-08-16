using System;
using BussinessLayer;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectProductt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CategoryManeger cm = new CategoryManeger();
            foreach(var item in cm.GetAll())
            {
                Console.WriteLine("ID: "+item.CategoryID+" -Category Name "+ item.CategoryName);
            }
            Console.Read();
        }
    }
}
