using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson___Abstraction
{
    public abstract class GeometricShape
    {
        //PROPERTIES
        //public double SideA { get; set; }
        //public double SideB { get; set; }
        //public double SideC { get; set; }
        //public double SideD { get; set; }

        //CONSTRUCTOR
        //public GeometricShape(double sideA, double sideB, double sideC, double sideD)
        //{
        //    SideA = sideA;
        //    SideB = sideB;
        //    SideC = sideC;
        //    SideD = sideD;
        //}

        //METHOD
        public abstract double GetArea();//abstract 

        //nereikia nieko. palikti tusica       


        public abstract double GetPerimeter(); //abstract 
        //nereikia nieko. palikti tusica  


        // END OF METHODS
    }
}
