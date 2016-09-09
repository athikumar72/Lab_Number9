using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 

namespace Lab_number9
{
    public class CircleApp
    {
        static void Main(string[] args)

        {

            string option;
            int objectNumber;
            
            Console.WriteLine("Welcome To the Circle Tester");
           do {
                bool check = false;
                string radius_input;
                double radius;

            do
            {

                    //double rad = double.Parse(Console.ReadLine()); 
                    Console.WriteLine("Enter radius : ");
                    radius_input = Console.ReadLine();
                check = Validator.radius_validator(radius_input, out radius);
                Console.WriteLine("x is : " + radius + " input string is   " + radius_input + " " + check);
                    Console.WriteLine("Please Enter valid number");
            } while (!check);

            Console.WriteLine("Enter radius : ");

            Circle circle_object = new Circle(radius);


            Console.WriteLine("Circumference:  " + circle_object.getFormattedCircumference());

            Console.WriteLine("Area:  " + circle_object.getFormattedArea());
            objectNumber = Circle.getObjectCount();

            Console.WriteLine("Continue?(y/n):  ");
            option = Console.ReadLine().ToLower();

        } 
        while (option == "y");

            Console.WriteLine($"Goodbye.You created   {objectNumber} circle object(s) ");

        }
    }
}
