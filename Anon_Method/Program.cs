using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anon_Method
{
    public delegate void MyDelegate();
    class Program
    {
        static void Main(string[] args)
        {
            MyDelegate mD = new MyDelegate(delegate { Console.WriteLine("Hello World!"); });
            mD();
            Console.ReadLine();
        }
    }
}
