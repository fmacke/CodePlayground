using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePlayground.DynamicProgramming
{
    /// <summary>
    /// Provides a solution to the House Robber problem using a dynamic programming table and integer array to optimize the computation     
    /// </summary>
    /// 
    /// <remarks>
    /// This is a BOTTOM UP approach to this dynamic programming problem.  
    /// The advantage of this approach is that it reduces the space complexity of the solution vs recursion and memoisation because
    /// we don't have a recursion stack. When the number of houses is large, a recursion stack can become a serious limitation, which
    /// can ultimately lead to compiler running into stack-overflow problems.  See LeetCode problem 198 for more details.
    /// </remarks>
    public class HouseRobber_DPTable : ISolution
    {
        private int[] nums;

        public HouseRobber_DPTable(int[] nums)
        {
            this.nums = nums;
        }

        public int Solve()
        {
            int N = nums.Length;

            // Special handling for empty array case.
            if (N == 0)
            {
                return 0;
            }

            int[] maxRobbedAmount = new int[nums.Length + 1];

            // Base case initializations.
            maxRobbedAmount[N] = 0;
            maxRobbedAmount[N - 1] = nums[N - 1];

            // DP table calculations.
            for (int i = N - 2; i >= 0; --i)
            {
                // Same as the recursive solution.
                maxRobbedAmount[i] = Math.Max(
                    maxRobbedAmount[i + 1],
                    maxRobbedAmount[i + 2] + nums[i]
                );
            }

            return maxRobbedAmount[0];
        }

    }
}
