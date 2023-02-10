namespace GenericFindMax
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Generic Find Maximun Number");
            FindMaxNumber findMaxNumber = new FindMaxNumber();
            Console.WriteLine("Enter the number number 1,2,3 resp.");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Max number is :"+findMaxNumber.FindMaxValue_Int(num1, num2, num3)); 
        }
    }
}