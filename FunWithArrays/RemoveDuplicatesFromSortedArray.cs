namespace CodePlayground.FunWithArrays
{
    public static class RemoveDuplicatesFromSortedArray
    {
        public static int RemoveDuplicates(int[] nums)
        {
            int k = 0;
            bool zeroLoaded = false;
            int[] temp = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                if (!temp.Contains(nums[i]) || (nums[i] == 0 && !zeroLoaded))
                {
                    if (nums[i] == 0) zeroLoaded = true;
                    nums[k] = nums[i];
                    temp[k] = nums[i];
                    k++;
                }
            }
            Array.Resize(ref nums, k);
            return k;
        }
    }
}