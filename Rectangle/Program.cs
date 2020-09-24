using System;
namespace Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r1;
            r1 = new Rectangle(1, 1, 1, 1);
            r1.show();
            r1.lengths(2);
            r1.widths(2);
            r1.postion(2, 2);
            r1.show();
            r1.area();
            r1.perimeter();
            r1.contains();
            Console.WriteLine(r1.ToString());
        }
    }
}
