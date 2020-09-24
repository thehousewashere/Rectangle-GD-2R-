using System;
namespace Rectangle
{
    class Rectangle
    {
        private int x;
        private int y;
        private int length;
        private int width;
        public Rectangle()
        {
            int x = 0;
            int y = 0;
            int length = 0;
            int width = 0;
        }
        public Rectangle(int x, int y, int length, int width)
        {
            this.x = x;
            this.y = y;
            this.length = length;
            this.width = width;
        }
        public void show()
        {
            Console.WriteLine("Location: "+x+","+y+" |Length: "+length+" |Width: "+width);
        }       
        public void lengths(int l)
        {
            length = l;
        }
        public void widths(int w)
        {
            width = w;
        }
        public void postion(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public void area()
        {
            Console.WriteLine("Area: "+length * width+" ");
        }
        public void perimeter()
        {
            int per = (2 * length) + (2 * width);
            Console.WriteLine("Perimeter: " + per + " ");
        }
        public bool contains()
        {
            int location = x * y;
            int areas = length * width;

            if (location == areas)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("The rectangle is contained");
                Console.ForegroundColor = ConsoleColor.Gray;
                return true;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("The rectangle is not contained");
                Console.ForegroundColor = ConsoleColor.Gray;
                return false;
            }
        }
        public override string ToString()
        {
            string elam = ("(" + x + "," + y + "), " + length + ", " + width);
            return elam;
        }


    }
}


