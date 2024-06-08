using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //const int maxShapes = 20;

            //Shape[] shapes = new Shape[maxShapes];
            //for (int i = 0; i < maxShapes; i++)
            //{
            //    Console.WriteLine("What shape do you" +
            //    "wish to create?");
            //    Console.WriteLine("Circle or Rectangle (C or R)");
            //    string option = Console.ReadLine();
            //    char opt = option[0];
            //    if (opt == 'C')
            //    {
            //        shapes[i] = new Circle();
            //        Console.WriteLine("Circle Created");

            //    }
            //    else if (opt == 'R')
            //    {
            //        shapes[i] = new Rectangle();
            //        Console.WriteLine("Rectangle Created");

            //    }
            //    else
            //    {
            //        Console.WriteLine("Not Allowed");
            //    }
            //}

            object obj = "Hello, World";
            if(obj is string )
            {
                Console.WriteLine("Obj is string");
                string str = obj as string;
                if (str != null)
                {
                    Console.WriteLine($"Length of the string: {str.Length}");
                }
                Console.Read();
            }
            else { Console.WriteLine("obj is not string"); }
        }
    }
}
                

                

        
         
    

