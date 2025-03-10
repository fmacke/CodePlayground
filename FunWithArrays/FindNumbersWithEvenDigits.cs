namespace CodePlayground.FunWithArrays
{
    /// <summary>
    /// This class provides a solution to find the count of numbers with an even number of digits in a given array.
    /// </summary>
    public class FindNumbersWithEvenDigits : ISingleSolution
    {
        private int[] nums;
        public FindNumbersWithEvenDigits(int[] ints)
        {
            this.nums = ints;
        }

        /// <summary>
        /// Solves the problem by counting the numbers with an even number of digits in the array.
        /// </summary>
        /// <returns>The count of numbers with an even number of digits.</returns>
        public int Solve()
        {
            int count = 0;
            foreach (var num in nums)
            {
                if (num.ToString().Length % 2 == 0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
