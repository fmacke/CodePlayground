namespace CodePlayground.FunWithArrays
{
    public static class DeleteFromArray
    {
        public static int RemoveElement(int[] nums, int val)
        {
            int k = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[k] = nums[i];
                    k++;
                }
            }
            Array.Resize(ref nums, k);
            return k;
        }
    }
}