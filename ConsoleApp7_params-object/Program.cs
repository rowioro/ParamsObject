using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7_params_object
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Zamiana("Mam na imie #0 i mam #1 lat.", "Robert", 48));
            Console.ReadKey();
        }

        public static string Zamiana(string tekst, params object[]args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                tekst = tekst.Replace("#" + i, args[i].ToString());
            }
            return tekst;
        }
    }
}
