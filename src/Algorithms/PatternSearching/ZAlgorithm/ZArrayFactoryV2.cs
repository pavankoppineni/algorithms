using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.PatternSearching.ZAlgorithm
{
    public class ZArrayFactoryV2
    {
        public int[] Create(string pattern)
        {
            var zArray = new int[pattern.Length];
            int left = 0;
            int right = 0;
            for (var index = 1; index < pattern.Length; index++)
            {
                //Case 1 : When index is less than right
                if(index > right)
                {
                    left = index;
                    right = index;
                    var offset = 0;
                    while(right < pattern.Length)
                    {
                        if (pattern[offset] == pattern[right])
                        {
                            offset += 1;
                            right += 1;
                        }
                        else
                        {
                            zArray[index] = right - left;
                            right -= 1;
                            break;
                        }
                    }
                }
                //Case 2 : When index is greater than right
                else
                {

                }
            }

            return zArray;
        }
    }
}
