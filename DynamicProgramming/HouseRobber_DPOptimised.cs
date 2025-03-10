namespace CodePlayground.DynamicProgramming
{
    /// <summary>
    /// Provides a solution to the House Robber problem with optimised performance
    /// </summary>
    /// 
    /// <remarks>
    /// This is a BOTTOM UP approach to this dynamic programming problem.  
    /// The advantage of this approach is that it reduces the space complexity of the solution vs recursion and memoisation (TOP DOWN) because
    /// we don't have a recursion stack. The advantage of this approach over using the dynamic programming table (also BOTTOM UP approach) is
    /// that we only need to keep track of 2 variables at any give time, reducing memory load required at runtime.
    /// </remarks>
    public class HouseRobber_DPOptimised : ISingleSolution
    {
        private int[] nums;

        public HouseRobber_DPOptimised(int[] ints)
        {
            this.nums = ints;
        }

        public int Solve()
        {
            int N = nums.Length;

            // Special handling for empty array case.
            if (N == 0) return 0;

            int robNext, robNextPlusOne;

            // Base case initializations.
            robNextPlusOne = 0;
            robNext = nums[N - 1];

            // DP table calculations. Note: we are not using any
            // table here for storing values. Just using two
            // variables will suffice.
            for (int i = N - 2; i >= 0; --i)
            {
                // Same as the recursive solution.
                int current = Math.Max(robNext, robNextPlusOne + nums[i]);
                // Update the variables
                robNextPlusOne = robNext;
                robNext = current;
            }

            return robNext;
        }
    }
}