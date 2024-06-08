using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_Project
{
    internal class Circle:Shape
    {
        int radius;
        Circle(int x,int y,int radius):base(x,y) 
        {
            this.radius = radius;
        }
        public int Radius
        {
            get { return radius; }
            set { radius = value; }
        }
        public void SetValues(int x, int y, int radius)
        {
            X = x;
            Y = y;
            this.radius = radius;
        }
        public override void Area()
        {
            Console.WriteLine(X * Y * radius);
            Console.Read();
        }
        static void Main(string[] args)
        {
            int i = 0;
            Shaape[] shapes = new Shaape[20];

            while (i < shapes.Length)
            {
                Console.WriteLine("What shape do you wish to create?");
                Console.WriteLine("Circle or Rectangle (C or R)");
                string option = Console.ReadLine();
                char opt = option.ToUpper()[0];

                if (opt == 'C')
                {
                    Console.WriteLine("Enter the x-coordinate:");
                    int x = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the y-coordinate:");
                    int y = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the radius:");
                    double radius = double.Parse(Console.ReadLine());

                    shapes[i] = new Circles(radius,x, y);
                }
                else if (opt == 'R')
                {
                    Console.WriteLine("Enter the x-coordinate:");
                    int x = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the y-coordinate:");
                    int y = int.Parse(Console.ReadLine());

                    shapes[i] = new Rectangle(x,y);
                }
                else
                {
                    Console.WriteLine("Invalid option. Please enter C or R.");
                    continue; // Skip the rest of the loop and start again.
                }

                Console.WriteLine($"Area of the created shape: {shapes[i].Area()}");

                i++;
            }
        }


    }
}
