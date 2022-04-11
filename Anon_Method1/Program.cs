using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anon_Method1
{
    public delegate int AddDelegate(int a, int b);
    class Program
    {
        static void Main(string[] args)
        {
            AddDelegate aD = new AddDelegate(delegate (int num1, int num2)
            {
                int res = num1 + num2;
                return res;
            });
            int sum = aD(5, 4);
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
