﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_Concepts_Assignment_2
{
    // A Dynamic Programming solution
    // for Rod cutting problem
    using System;
    class GFG
    {

        /* Returns the best obtainable
        price for a rod of length n
        and price[] as prices of
        different pieces */
        public int cutRod(int[] price, int n)
        {
            int[] val = new int[n + 1];
            val[0] = 0;

            // Build the table val[] in
            // bottom up manner and return
            // the last entry from the table
            for (int i = 1; i <= n; i++)
            {
                int max_val = int.MinValue;
                for (int j = 0; j < i; j++)
                    max_val = Math.Max(max_val,
                        price[j] + val[i - j - 1]);
                val[i] = max_val;
            }

            return val[n];
        }

    }


}
