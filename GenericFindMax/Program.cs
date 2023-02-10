using System.IO;
using System;

namespace GenericFindMax
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Generic Find Maximun Number");
            FindMaxNumber findMaxNumber = new FindMaxNumber();
            try
            {
                Console.WriteLine("Hint 1.FindMax Interger 2.FindMax Float 3.FindMax String 4.GenericMethod 5.Generic class");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter the Interger number 1,2,3 resp.");
                        int num1 = Convert.ToInt32(Console.ReadLine());
                        int num2 = Convert.ToInt32(Console.ReadLine());
                        int num3 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Max number is :"+findMaxNumber.FindMaxValue_Int(num1, num2, num3));
                        break;
                    case 2:
                        Console.WriteLine("Enter the Float number 1,2,3 resp.");
                        float flonum1 = float.Parse(Console.ReadLine());
                        float flonum2 = float.Parse(Console.ReadLine());
                        float flonum3 = float.Parse(Console.ReadLine());
                        Console.WriteLine("Max number is :"+findMaxNumber.FindMaxValue_Float(flonum1, flonum2, flonum3));
                        break;
                    case 3:
                        Console.WriteLine("Maximum string is :"+findMaxNumber.FindMaxStringValue("Apple","Peach","Bananan"));
                        break;
                    case 4:
                        FindMaxGenericMethod genericMethodPro = new FindMaxGenericMethod();
                        int resultInterger = genericMethodPro.FindMaxMethod(30, 2, 5);
                        float resultFloat = genericMethodPro.FindMaxMethod(30.6F, 5.4F, 6.7F);
                        string resultString = genericMethodPro.FindMaxMethod("Apple", "Banana", "Peach");
                        Console.WriteLine("Maximum Number is :"+resultInterger+"\n Max Float number is :"+resultFloat+"\nMax string is :"+resultString);
                        break;
                    case 5:
                        FindMaxGenericClass<int> genericClassInt = new FindMaxGenericClass<int>(30, 2, 5);
                        int result1 = genericClassInt.FindMaxValue();
                        Console.WriteLine("Max value :"+result1);
                        FindMaxGenericClass<float> genericClassFloat = new FindMaxGenericClass<float>(30.6F, 5.4F, 6.7F);
                        float result2 = genericClassFloat.FindMaxValue();
                        Console.WriteLine("Maximum Value Float Value :"+result2);
                        FindMaxGenericClass<string> genericClassString = new FindMaxGenericClass<string>("Apple", "Banana", "Peach");
                        string result3 = genericClassString.FindMaxValue();
                        Console.WriteLine("Max String Value :"+result3);
                        break;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}