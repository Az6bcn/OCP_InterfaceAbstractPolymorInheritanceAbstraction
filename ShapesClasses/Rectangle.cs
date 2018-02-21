using System;
namespace SOLID_OCP.Model
{
    public class Rectangle: IShape
    {
        public Rectangle()
        {
        }

        public double Width { get; set; } = 5;
        public double Height { get; set; } = 6;


        public double Area(){

            return Width * Height;
        }
    }
}
