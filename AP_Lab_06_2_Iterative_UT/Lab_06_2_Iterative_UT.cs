/* Lab_06_2_Iterative_UT.cs
 * Якубовський Владислав
 * Unit-test до програми Lab_06_2_Iterative.cs */
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using static AP_Lab_06_2_Iterative.Lab_06_2_Iterative;

namespace AP_Lab_06_2_Iterative_UT
{
    [TestClass]
    public class Lab_06_2_Iterative_UT
    {
        [TestMethod]
        public void TestReverseSortArray()
        {
            int[] arrayToSort = { -1, -2, -3, 4, 5 },
                expectedSortedArray = { 5, 4, -1, -2, -3 };
            
            ReverseSortArray(ref arrayToSort);

            Assert.IsTrue(Enumerable.SequenceEqual(expectedSortedArray, arrayToSort));            
        }
    }
}
