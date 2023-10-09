using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson___Abstraction
{
    public class Square : GeometricShape
    {

        //PROPERTIES
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }
        public double SideD { get; set; }
        //CONSTRUCTOR


        public Square(double sideA, double sideB, double sideC, double sideD) 
        { 
        SideA = sideA;
            SideB = sideB;
            SideC = sideC;
            SideD = sideD;
        }
        //: base (sideA, sideB,sideC,sideD) { }



        //METHOD

        public override double GetArea()// nereikia cia paduoti kintamuju
        {
            double area = SideA * SideB;//naudojam parametrus
            return area;
        }

        public override double GetPerimeter()
        {
            double perimeter = SideA + SideB + SideC + SideD;
            return perimeter;
        }

        public double GetArea2(double sideA, double sideB)// kadangi cia nusirodome kintamuosius is konstruktoraiaus, tai pagr. faile reikes darsyk ivesti is naujo kvadrato parametrus. 
            //vien properties neuzteks
        {
            double area = sideA * sideB;
            return area;
        }

        //END OF METHODS

    }
}
