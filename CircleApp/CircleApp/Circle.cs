using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_number9
{
   
        class Circle
    {

        public double radius;
        double circumference;

        double Area;
        string formatted_circumference;
        string formated_area;
       string formated_value;
        public static  int no_of_Objects=0;
        public Circle(double radius)
        {
           this.radius = radius;

            no_of_Objects++;
        }

        public double getCircumference()
        {
             circumference = 2 * Math.PI * radius;

            return circumference;
        }
        public String getFormattedCircumference()
        {
            double cal_cirumfernce = getCircumference();
            formatted_circumference = formatNumber(cal_cirumfernce);

            //double formatted_Circumference_d= Math.Round(circumference, 2);
            //  formatted_circumference = formatted_Circumference_d.ToString();
            return formatted_circumference;
        }
        public double getArea()
        {
            Area = Math.PI * radius * radius;
            return Area;

        }
        public String getFormattedArea()
        {
           double cal_Area= getArea();
         return  formated_area= formatNumber(cal_Area);

           // double Area_formatted = Math.Round(circumference, 4);
           // formated_area= Area_formatted.ToString();
           // return formated_area;

        }

        private string formatNumber(double x)
        {

            double formatted_value1 = Math.Round(x, 2);

            formated_value = formatted_value1 .ToString();
            return formated_value;

        }

        public static int getObjectCount()
        {
            return no_of_Objects;
        }
    }
}
