using System.Runtime.Intrinsics.Arm;
using Xunit.Sdk;

namespace CodePlayground.DynamicProgramming
{
    public class HouseRobber_RecurseAndMemoise : ISolution
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