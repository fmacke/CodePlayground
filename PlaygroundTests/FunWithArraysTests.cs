using CodePlayground.FunWithArrays;

namespace PlaygroundTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void FindNumbersWithEvenDigits()
        {
            var input = new int[] { 12, 345, 2, 6, 7896 };
            var expected = 2;
            var actual = new FindNumbersWithEvenDigits(input).Solve();
            Assert.AreEqual(expected, actual);

            input = new int[] { 555, 901, 482, 1771 };
            expected = 1;
            actual = new FindNumbersWithEvenDigits(input).Solve();
            Assert.AreEqual(expected, actual);

            input = new int[] { 5555, 901, 480026, 17751 };
            expected = 2;
            actual = new FindNumbersWithEvenDigits(input).Solve();
            Assert.AreEqual(expected, actual);


            input = new int[] { 5555, 236984, 20, 6 };
            expected = 3;
            actual = new FindNumbersWithEvenDigits(input).Solve();
            Assert.AreEqual(expected, actual);

        }
        [Test]
        public void SquaresOfASortedArrayTest()
        {
            var input = new int[] { -4, -1, 0, 3, 10 };
            var expected = new int[] { 0, 1, 9, 16, 100 };
            var actual = new SquaresOfASortedArray(input).Solve();
            Assert.AreEqual(expected, actual);

            input = new int[] { -7, -3, 2, 3, 11 };
            expected = new int[] { 4, 9, 9, 49, 121 };
            actual = new SquaresOfASortedArray(input).Solve();
            Assert.AreEqual(expected, actual);

        }
        [Test]
        public void DuplicateZeroesTest()
        {
            var input = new int[] { 1, 0, 2, 3, 0, 4, 5, 0 };
            var expected = new int[] { 1, 0, 0, 2, 3, 0, 0, 4 };
            var actual = new DuplicateZeros(input).Solve();
            Assert.AreEqual(expected, actual);

            input = new int[] { 1, 2, 3 };
            expected = new int[] { 1, 2, 3 };
            actual = new DuplicateZeros(input).Solve();
            Assert.AreEqual(expected, actual);

        }
        [Test]
        public void MergeSortedArrayTest()
        {
            var input1 = new int[] { 1, 2, 3, 0, 0, 0 };
            var input2 = new int[] { 2, 5, 6 };
            int m = 3;
            int n = 3;
            var expected = new int[] { 1, 2, 2, 3, 5, 6 };
            var actual = new MergeSortedArray(input1, m, input2, n).Solve();
            Assert.AreEqual(expected, input1);


        }
    }
}