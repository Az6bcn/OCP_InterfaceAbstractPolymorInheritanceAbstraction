using System;
namespace SOLID_OCP.Model
{
    public class Circle: IShape
    {
        public Circle()
        {
        }


		public double Radius { get; set; } = 5;

		public double Area()
		{

            return 2 * 3.14 * Radius;
		}
    }
}
