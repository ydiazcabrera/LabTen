using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTen
{
    public class Circle
    {
        //Create a class named Circle to store the data about this circle.This class should contain these constructors and methods:
        //Define an instance variable called radius, which should be private. 
        //public Circle(double radius) - this constructor should take in and initialize radius.
        //public double GetCircumference() - using the radius this should return the circle’s circumference
        //public double GetArea() - using the radius this should return the area of the circle.
        //Public void PrintInfo() - using the other methods this should print the following in this order: 
        //The Radius
        //The Area
        //The Circumference




        private double radius;

        public Circle(double r)
        {
            //this.radius = radius;
            radius = r;
            // test
           // Console.WriteLine("radius equals" + radius);
        }

        public double GetCircumference()
        {
            //input the circumference formula and return the result
            double output = Math.Floor(2 * Math.PI * radius);
            return output;
        }
        public double GetArea()
        {
            double area = Math.Floor(Math.PI * Math.Pow(radius, 2));
            return area;
        }
        public void PrintInfo()
        {
            Console.WriteLine($"Radius: {radius}" );
            Console.WriteLine($"Area: {GetArea()}");
            Console.WriteLine($"Circumference: {GetCircumference()}");
        }
    }
        
}
