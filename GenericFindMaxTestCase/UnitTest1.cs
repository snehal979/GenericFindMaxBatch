using GenericFindMax;

namespace GenericFindMaxTestCase
{
    [TestClass]
    public class UnitTest1
    {
        FindMaxNumber findMaxNumber = new FindMaxNumber();
        /// <summary>
        /// Uc1.1 Given Max and return First test case
        /// </summary>
        [TestMethod]
        public void GivenMaxFirstNum_WhenAnalysed_ShouldReturnFistMaxNum()
        {
            //AAA
            //arrage initializatiion of vaiables
            int result = findMaxNumber.FindMaxValue_Int(30, 2, 5);
            // act creation of object and calling particular 
            //assert validation the output
            Assert.AreEqual(30, result);
        }
        /// <summary>
        /// Uc1.2 Given Second Max Value and return Second test case
        /// </summary>
        [TestMethod]
        public void GivenMaxSecondNum_WhenAnalysed_ShouldReturnSecondMaxNum()
        {
            int result = findMaxNumber.FindMaxValue_Int(3, 30, 5);
            Assert.AreEqual(30, result);
        }
        /// <summary>
        /// Uc1.3 Given Third Max Value and return Third test case
        /// </summary>
        [TestMethod]
        public void GivenMaxThirdNum_WhenAnalysed_ShouldReturnThirdMaxNum()
        {
            int result = findMaxNumber.FindMaxValue_Int(3, 5, 30);
            Assert.AreEqual(30, result);
        }
        

        /// <summary>
        /// Uc2.1 Given First Max Value and return First test case
        /// </summary>
        [TestMethod]
        public void GivenMaxFirstNum_WhenAnalysed_ShouldReturnFirstMaxNum_FloatNumber()
        {
            float result = findMaxNumber.FindMaxValue_Float(30.8F, 5.4F, 30.0F);
            Assert.AreEqual(30.8F, result);
        }
        /// <summary>
        /// Uc2.2 Given Second Max Value and return Second test case
        /// </summary>
        [TestMethod]
        public void GivenMaxSecondNum_WhenAnalysed_ShouldReturnSecondMaxNum_FloatNumber()
        {
            float result = findMaxNumber.FindMaxValue_Float(5.4F, 30.8F, 30.0F);
            Assert.AreEqual(30.8F, result);
        }
        /// <summary>
        /// Uc2.3 Given Third Max Value and return Third test case
        /// </summary>
        [TestMethod]
        public void GivenMaxThirdNum_WhenAnalysed_ShouldReturnThirdMaxNum_FloatNumber()
        {
            float result = findMaxNumber.FindMaxValue_Float(5.4F, 30.0F, 30.8F);
            Assert.AreEqual(30.8F, result);
        }


        /// <summary>
        /// UC3.1 Find max string given First String and return It
        /// </summary>
        [TestMethod]
        public void GivenMaxFirstStringValue_WhenAnalysed_ShouldReturnFirstMax()
        {
            string result = findMaxNumber.FindMaxStringValue("Peach", "Apple", "Banana");
            Assert.AreEqual("Peach", result);
        }
        /// <summary>
        /// UC3.2 Find max string given Second String and return It
        /// </summary>
        [TestMethod]
        public void GivenMaxSecondStringValue_WhenAnalysed_ShouldReturnSecondMax()
        {
            string result = findMaxNumber.FindMaxStringValue( "Apple", "Peach", "Banana");
            Assert.AreEqual("Peach", result);
        }
        /// <summary>
        /// UC3.3 Find max string given Third String and return It
        /// </summary>
        [TestMethod]
        public void GivenMaxThirdStringValue_WhenAnalysed_ShouldReturnThirdMax()
        {
            string result = findMaxNumber.FindMaxStringValue("Apple", "Banana", "Peach");
            Assert.AreEqual("Peach", result);
        }


        /// <summary>
        /// Uc4 Generic Method 
        /// </summary>
        [TestMethod]
        public void MethodGivenNumber_WhenAnalyse_ShouldReturnMaxValue()
        {
            FindMaxGenericMethod genericMethod = new FindMaxGenericMethod();

            int resultInterger = genericMethod.FindMaxMethod(30, 2, 5);
            float resultFloat = genericMethod.FindMaxMethod(30.6F, 5.4F, 6.7F);
            string resultString = genericMethod.FindMaxMethod("Apple", "Banana", "Peach");

            Assert.AreEqual(30, resultInterger);
            Assert.AreEqual(30.6F, resultFloat);
            Assert.AreEqual("Peach", resultString);
        }


        /// <summary>
        /// Uc5 Generic Class
        /// </summary>
        [TestMethod]
        public void ClassGivenNumber_WhenAnalyse_ShouldReturnMaxValue()
        {
            FindMaxGenericClass<int> genericClassInt = new FindMaxGenericClass<int>(30, 2, 5);
            int result1 = genericClassInt.FindMaxValue();
            Assert.AreEqual(30, result1);

            FindMaxGenericClass<float> genericClassFloat = new FindMaxGenericClass<float>(30.6F, 5.4F, 6.7F);
            float result2 = genericClassFloat.FindMaxValue();
            Assert.AreEqual(30.6F, result2);

            FindMaxGenericClass<string> genericClassString = new FindMaxGenericClass<string>("Apple", "Banana", "Peach");
            string result3 = genericClassString.FindMaxValue();
            Assert.AreEqual("Peach", result3);
        }
    }
}