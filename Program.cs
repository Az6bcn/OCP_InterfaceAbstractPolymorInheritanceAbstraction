using System;
using System.Collections.Generic;
using SOLID_OCP.Model;

namespace SOLID_OCP
{
    public class MainClass
    {

        public double CalculateShapeArea(IShape shape){
            
            return shape.Area();
        }

        public void AreaShapes(List<IShape> shapes){
            foreach(IShape shape in shapes){
                Console.WriteLine("shape area is {0}", shape.Area());
            }
        }


        public static void Main(string[] args)
        {

           
            Console.WriteLine("Hello World!");

			// Declare class object
			MainClass m = new MainClass();

			// Declare Instance of class implementing the interface
			IShape s = new Rectangle();
            var RectangleArea = m.CalculateShapeArea(s);

            // var RectangleArea = m.CalculateShapeArea(new Rectangle());

            Console.WriteLine(RectangleArea);


            var shapeList = new List<IShape>() { new Rectangle(), new Circle() };

            m.AreaShapes(shapeList);

            Console.ReadLine();
        }

    }
}


/* 
 * Ishape s = new Rectangle(); --> creates an interface reference named 's' to the instance created by the new Rectangle();
 * Rectangle r = new Rectangle(); --> creates an object reference name customer to the instance created by the new Customer();
 * 
 * While both references point to an instance of the Rectangle class, they are different. 
 ***** The interface reference only offers what is defined in the ICustomer interface, regardless of what else the Customer class makes available.
 ***** The object reference gives you everything the Customer class has to offer.
 *
 *https://softwareengineering.stackexchange.com/questions/278052/why-are-objects-instantiated-this-way
 */