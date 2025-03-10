using CodePlayground;
namespace CodePlayground.FunWithArrays
{
    public class SquaresOfASortedArray : IArraySolution
    {
        private int[] _input;
        public SquaresOfASortedArray(int[] nums)
        {
            _input = nums;
        }
        public int[] Solve()
        {
            int[] result = new int[_input.Length];
            for (int i = 0; i < _input.Length; i++)
            {
                result[i] = (int)Math.Pow(_input[i], 2);
            }
            Array.Sort(result);
            return result;
        }
    }
}
