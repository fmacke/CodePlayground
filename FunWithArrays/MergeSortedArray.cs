using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePlayground.FunWithArrays
{
    public class MergeSortedArray : IArraySolution
    {
        int[] nums1, nums2;
        int m, n;
        public MergeSortedArray(int[] Nums1, int M, int[] Nums2, int N)
        {
            nums1 = Nums1;
            nums2 = Nums2;
            m = M;
            n = N;
        }
        public int[] Solve()
        {
            for(int i = 0; i < nums2.Length; i++)
            {
                for (int j = 0; j < nums1.Length; j++)
                {
                    if (nums2[i] < nums1[j])
                    {
                        for (int k = nums1.Length - 1; k > j; k--)
                        {
                            nums1[k] = nums1[k - 1];
                        }
                        nums1[j] = nums2[i];
                        break;
                    }
                }
            }
            return nums1;
        }

    }
}
