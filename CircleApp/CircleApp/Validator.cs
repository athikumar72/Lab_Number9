using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_number9

{
    public static class Validator
    {

        public static bool radius_validator(string radius ,out double x)



        {
           // double x;




            if (double.TryParse(radius, out x))
                {
                if (x <= 0)
                    return false;
                else
                    return   true;

            }
            return false;



        }
    }
}

