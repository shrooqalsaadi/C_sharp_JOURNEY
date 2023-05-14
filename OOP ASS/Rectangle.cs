using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_ASS
{
    internal class Rectangle
    {

        
        public int area_rec;
        public double  area_rec1;
        public int area(int Length, int Width)
        {
            area_rec = Length * Width;
            return area_rec;
        }
        public double area(double Length, double Width)
        {
            area_rec1 = Length * Width;
            return area_rec1;

        }
        public void area_rectangle()
        {
            double width = 3.8;
            double height = 1.8;
            area_rec1=width* height;
            Console.WriteLine(area_rec1);

        }


    }
        
        
}
