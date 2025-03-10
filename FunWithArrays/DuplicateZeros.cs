namespace CodePlayground.FunWithArrays
{
    public class DuplicateZeros : IArraySolution
    {
        private int[] _input;
        public DuplicateZeros(int[] nums)
        {
            _input = nums;
        }
        public int[] Solve()
        {
            for (int i = 0; i < _input.Length; i++)
            {
                if( _input[i] == 0 )
                {
                    for (int j = _input.Length - 1; j > i; j--)
                    {
                        _input[j] = _input[j - 1];
                    }
                    i++;
                }
            }
            return _input;
        }
    }
}
