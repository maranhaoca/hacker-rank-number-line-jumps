using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Src
{
    public class Result
    {
        /*
     * Complete the 'kangaroo' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts following parameters:
     *  1. INTEGER x1
     *  2. INTEGER v1
     *  3. INTEGER x2
     *  4. INTEGER v2
     */

        public static string kangaroo(int x1, int v1, int x2, int v2)
        {
            string sameLoc = "null";
            if (x1 > x2)
            {
                while(x2 < x1)
                {
                    x1 += v1;
                    x2 += v2;
                    sameLoc = x1 == x2 ? "YES" : "NO";
                }
            }
            if (x1 < x2)
            {
                while(x1 < x2)
                {
                    x1 += v1;
                    x2 += v2;
                    sameLoc = x1 == x2 ? "YES" : "NO";
                }
            }

            return sameLoc;
        }
    }
}