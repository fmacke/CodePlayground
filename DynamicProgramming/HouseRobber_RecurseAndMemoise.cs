namespace CodePlayground.DynamicProgramming
{
    /// <summary>
    /// this class provides a solution to the House Robber problem using a recursive approach with memoization to optimize the computation
    /// </summary>
    /// <remarks>
    /// This is a TOP DOWN approach to this dynamic programming problem.  It's OK for small inputs, but can run into stack overflow issues.
    /// See other approaches to same project in this folder for more details.
    /// See leetcode problem 198 for more details.
    /// </remarks>
    public class HouseRobber_RecurseAndMemoise : ISingleSolution
    {
        private int[] nums;
        private Dictionary<int, int> map = new Dictionary<int, int>();

        public HouseRobber_RecurseAndMemoise(int[] nums)
        {
            this.nums = nums;
        }

        public int Solve()
        {
            return Dp(nums.Length - 1);
        }

        private int Dp(int i)
        {
            if (i == 0) return nums[0];
            if(i == 1) return Math.Max(nums[0], nums[1]);
            if(map.ContainsKey(i)) return map[i];
            map.Add(i, Math.Max(Dp(i-1), Dp(i - 2) + nums[i]));
            return map[i];
        }
    }
}