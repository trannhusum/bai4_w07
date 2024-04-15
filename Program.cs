using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai4_w07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle(2,3);
            Circle circle = new Circle(3);
            Console.WriteLine("Truoc khi doi kich thuoc");
            Console.WriteLine(r);
            Console.WriteLine(circle);
            Console.WriteLine("Sau khi doi kich thuoc");
            r.Resize(2);
            circle.Resize(3);
            Console.WriteLine(r);
            Console.WriteLine(circle);
            Console.ReadKey();

        }
    }
}
