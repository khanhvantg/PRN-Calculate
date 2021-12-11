using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoRPN
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine().Trim();
            Scan k = new Scan(input);
            k.xuat();
            //Stack<char> a = new Stack<char>(5);
            //a.Push('5');
            //a.Push('4');
            //a.Push('3');
            //a.Push('2');
            //Console.WriteLine(a.Peek());
            //Console.WriteLine(a.Pop());
        }
    }
}
