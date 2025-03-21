using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate void del();

    class dell
    {
        
        public void Name(del pr)
        {
            Console.WriteLine("Harsh");
            pr();
        }
    }
    class Program
    {
        private static void Sur()
        {
            Console.WriteLine("Kandu");
        }

        static void Main(string[] args)
        {
            del de = Sur;
            dell d = new dell();
            d.Name(de);
        }
    }
}
