using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserCollections
{
    public class Helper
    {
        public static IEnumerable<int> GetSquaresOdd(IEnumerable<int> numbers)
        {
            foreach (int n in numbers)
            {
                if (n % 2 != 0)
                {
                    yield return n * n;
                }
            }
        }
    }
}
