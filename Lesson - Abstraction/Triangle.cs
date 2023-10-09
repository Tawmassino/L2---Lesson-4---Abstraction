using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson___Abstraction
{
    public class Triangle : GeometricShape
    {
        //PROPERTIES
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }

        //CONSTRUCTOR
        public Triangle(double sideA, double sideB, double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;          
        }

        //METHOD
        public override double GetArea()
        {
            double area =  (SideA + SideB +  SideC) / 2;
            return area;
        }

        public override double GetPerimeter()
        {
            double perimeter = SideA + SideB + SideC;
            return perimeter;
        }



        //END OF METHOD
    }
}
