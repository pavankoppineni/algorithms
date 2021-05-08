using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.PatternSearching
{
    public class ZArrayFactoryV1
    {
        public int[] CreateZArray(string pattern)
        {
            var zArray = new int[pattern.Length];
            zArray[0] = -1;
            for (var i = 1; i < pattern.Length; i++)
            {
                var count = 0;
                var prefixIndex = 0;
                for (var j = i; j < pattern.Length; j++)
                {
                    //Case 1 : When character
                    if (pattern[j] == pattern[prefixIndex])
                    {
                        prefixIndex += 1;
                        count += 1;
                    }
                    else
                    {
                        break;
                    }
                }
                zArray[i] = count;
            }

            return zArray;
        }
    }
}
