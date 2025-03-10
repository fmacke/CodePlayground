using CodePlayground.FunWithArrays;

namespace TestProject1
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
    }
}