/* Lab_06_2_Recursive_UT.cs
 * Якубовський Владислав
 * Unit-test до програми Lab_06_2_Recursive.cs */
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using static AP_Lab_06_2_Recursive.Lab_06_2_Recursive;

namespace AP_Lab_06_2_Recursive_UT
{
    [TestClass]
    public class Lab_06_2_Recursive_UT
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
