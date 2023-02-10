using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericFindMax
{
    public class FindMaxGenericMethod
    {
        public T FindMaxMethod<T>(T value1, T value2, T value3) where T : IComparable
        {
            if (value1.CompareTo(value2)>=0 && value1.CompareTo(value3)>=0)
            {
                return value1;

            }
            else if (value2.CompareTo(value1)>=0 && value2.CompareTo(value3)>=0)
            {
                return value2;
            }
            else
            {
                return value3;
            }
        }
    }
}
