using GenericFindMax;

namespace GenericFindMaxTestCase
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Uc1.1 Given Max and return First test case
        /// </summary>
        [TestMethod]
        public void GivenMaxFirstNum_WhenAnalysed_ShouldReturnFistMaxNum()
        {
            FindMaxNumber findMaxNumber = new FindMaxNumber();
            //AAA
            //arrage initializatiion of vaiables
            int result = findMaxNumber.FindMaxValue_Int(30, 2, 5);
            // act creation of object and calling particular 
            //assert validation the output
            Assert.AreEqual(30, result);
        }

    }
}