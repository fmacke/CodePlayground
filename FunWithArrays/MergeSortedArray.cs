namespace CodePlayground.FunWithArrays
{
    public class MergeSortedArray 
    {
        public MergeSortedArray(ref int[] nums1, int m, int[] nums2, int n)
        {
            if (nums1.Length < 1)
            {
                Array.Resize(ref nums1, n);
                for (int i = 0; i < nums2.Length; i++)
                    nums1[i] = nums2[i];
            }
            else
            {
                var count = 0;
                for (int i = m; i < m + n; i++)
                {
                    nums1[i] = nums2[count];
                    count++;
                }
            }
            Array.Sort(nums1);
        }

    }
}
