using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericFindMax
{
    public class FindMaxNumber
    {
        /// <summary>
        /// Uc 1 FindMaxNumber
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <param name="num3"></param>
        /// <returns></returns>
        public int FindMaxValue_Int(int num1, int num2, int num3)
        {
            if (num1>num2 && num1>num3)
            {
                return num1;

            }
            else if (num2>num3 && num2>num3)
            {
                return num2;
            }
            else
            {
                return num3;
            }

        }
    }
}
