using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U16_Modular_Calculator
{
    class Calculator
    {
         //Rectangle Area function
        public double Rectangle(double num1, double num2)
        {
            return num1 * num2;
        }
        
        //Circle Area Function
        public double Circle(double radius)
        {
            
                
                double pi = Math.PI;


            return pi * (radius * radius); ;

         }

        //Triangle area function 
        public double Triangle(double num1, double num2)
        {
            return num1 * num2 / 2;
        }

 

   
    }
}
