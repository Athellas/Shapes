﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Polymorphism *****\n");
            Hexagon hex = new Hexagon("Beth");
            hex.Draw();

            Circle cir = new Circle("Cindy");
            // Calls base class implementation!
            cir.Draw();
            Console.ReadLine();

            Shape[] myShapes = { new Hexagon(), new Circle(), new Hexagon("Mick"), new Circle("Beth"), new Hexagon("Linda")};

            foreach (Shape s in myShapes)
            {
                s.Draw();
            }
            Console.ReadLine();

            ThreeDCircle o = new ThreeDCircle();
            o.Draw();

            ((Circle) o).Draw();
            Console.ReadLine();
        }
    }
}
