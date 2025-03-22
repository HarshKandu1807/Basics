using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace out_ref
{
    class Program
    {
        static void sf(ref int n,out int n1,int n2)//20,NULL,20
        {
            n1 = 0;//the n1 value given in caller is distroyed
            n = n + 10;//20+10=30 and return to caller
            n1 = n1 + 10;//0+10=10 and return to caller
            n2 = n2 + 10;//20+10=30 and the value gets ditroyed and value do not go to caller
        }
        static void Main(string[] args)
        {
            int n = 20;
            int n1 = 20;
            int n2 = 20;
            sf(ref n, out n1,n2);//ref value will be forwaded to calle and return back with new value to caller  and out value will be distroyed and n2 value wil also forward to calle but does not return to caller
            Console.WriteLine(n+" "+n1+" "+n2);
        }
    }
}
