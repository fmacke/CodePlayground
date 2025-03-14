namespace CodePlayground.FunWithArrays
{
    public static class DeleteFromArray
    {
        public static int RemoveElement(int[] nums, int val)
        {
            var doubleChecked = false;
            for (int x =0; x< nums.Length; x++)
            {
                if (nums[x] == val)
                {                    
                    for (int y = x + 1; y < nums.Length; y++)
                    {
                        nums[y - 1] = nums[y];
                    }
                }
                if (nums[x] == val)
                {
                    for (int y = x + 1; y < nums.Length; y++)
                    {
                        nums[y - 1] = nums[y];
                    }
                }
            }
            return nums.Count(v => v != val);
        }
    }
}