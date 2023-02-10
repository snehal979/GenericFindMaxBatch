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
    }
}