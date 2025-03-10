namespace CodePlayground.DynamicProgramming
{
    public class DeleteAndEarn : ISingleSolution
    {
        private static Dictionary<int, int> memo = new Dictionary<int, int>();
        private int[] ints;

        public DeleteAndEarn(int[] dataset)
        {
            ints = dataset;
        }

        public int Solve()
        {
            int recordBreaker = 0;
            int highestScore = 0;

            for (int i = 1; i < 2; i++)
            {
                highestScore = Math.Max(DeleteAndEarnsSingle(i - 1, ints.ToArray()), DeleteAndEarnsSingle(i, ints.ToArray()));
                if (highestScore > recordBreaker)
                {
                    recordBreaker = highestScore;
                }
            }

            return recordBreaker;
        }

        private static int DeleteAndEarnsSingle(int i, int[] ints)
        {
            Console.WriteLine("ints: " + ints.ToString());
            if (memo.ContainsKey(i)) return memo[i];
            int score = 0;
            if (ints[i] != 0)
            {
                int points = ints[i];

                for (int n = 0; n < ints.Length; n++)
                {
                    if (points == ints[n])
                    {
                        // add the points
                        score += points;
                        memo[n] = score;
                        continue;
                    }
                    else if (ints[n] == ints[i] + 1 || ints[n] == ints[i] - 1)
                    {
                        // remove the number
                        memo[n] = 0;
                        continue;
                    }
                    else
                    {
                        // ignore the number
                        memo[n] = ints[n];
                        continue;
                    }
                }
            }
            return DeleteAndEarnsSingle(i, memo.Values.ToArray());
        }
    }
}
