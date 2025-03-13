using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Methodology
{
    class FileName
    {
        public static string ArrayToString(int[] array)
        {
            return string.Join(" ", array);
        }


        public static int Sum(int[] array)
        {
            int sum = 0 ;
            foreach (var number in array)
            {
                sum += number;
            }
            return sum;
        }

        public static bool ContainsNegative(int[] array)
        {
            foreach (var number in array)
            {
                if (number < 0)
                {
                    return true;
                }
            }
            return false;
        }

        public static int Multiply(params int[] numbers)
        {
            int result = 1;
            foreach (var number in numbers)
            {
                result *= number;
            }
            return result;
        }

    }
}
