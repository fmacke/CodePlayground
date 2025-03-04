namespace CodePlayground.Classics
{
    public class FizzBuzz
    {
        private int number { get;set; }
        
        public FizzBuzz(int n)
        {
            number = n;
        }
        public List<string> Solve()
        {
            var list = new List<string>(number);

            for (int i = 1; i <= number; i++)
            {
                string item = (i % 3 == 0, i % 5 == 0) switch
                {
                    (true, true) => "FizzBuzz",
                    (true, false) => "Fizz",
                    (false, true) => "Buzz",
                    (false, false) => i.ToString()
                };

                list.Add(item);
            }

            return list;
        }
    }
}
