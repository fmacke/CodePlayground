using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace CodePlayground.Classics
{
    public class CracklePop
    {
        /// <summary>
        /// a program that prints out the numbers 1 to 100 (inclusive). If the number is divisible by 3, 
        /// print Crackle instead of the number.If it's divisible by 5, print Pop. If it's divisible by 
        /// both 3 and 5, print CracklePop.
        /// </summary>
        public List<string> PrintCracklePop()
        {
            var list = new List<string>(100);

            for (int i = 1; i <= 100; i++)
            {
                string item = (i % 3 == 0, i % 5 == 0) switch
                {
                    (true, true) => "CracklePop",
                    (true, false) => "Crackle",
                    (false, true) => "Pop",
                    (false, false) => i.ToString()
                };
                list.Add(item);
            }
            return list;
        }
    }
}
