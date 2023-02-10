using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericFindMax
{
    public class FindMaxGenericClass<T> where T :IComparable
    {
        T value1;
        T value2;
        T value3;
        public FindMaxGenericClass(T value1, T value2, T value3)
        {
            this.value1=value1;
            this.value2=value2;
            this.value3=value3;
        }
        public T FindMaxValue() 
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
