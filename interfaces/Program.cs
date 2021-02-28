using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces
{
    class Program : IName , ICity
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Using interfaces to print name and city");

            IName refname = new Program();
            ICity refCity = new Program();
            refname.PrintName();
            refCity.PrintCity();
            
            Console.ReadKey();

        }

        public void PrintName()
        {
            Console.WriteLine("Mark");
        }

        public void PrintCity()
        {
            Console.WriteLine("Boston");
        }
    }

    interface IName
    {
        void PrintName();
    }

    interface ICity
    {
        void PrintCity();
    }
}
