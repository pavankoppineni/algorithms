using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.PatternMatching.KmpAlgorithm
{
    public class KMPAlgorithmV2
    {
        public bool PatternExists(string str, string pattern)
        {
            var patternArray = pattern.ToCharArray();
            var textArray = str.ToCharArray();
            var prefixTable = GeneratePrefixTable(pattern);
            var j = 0;
            var i = 0;
            bool result = false;
            while (i < textArray.Length)
            {
                if (textArray[i] == patternArray[j])
                {
                    i++;
                    j++;
                    if (j >= pattern.Length)
                    {
                        result = true;
                        break;
                    }
                    continue;
                }

                if (j - 1 <= 0)
                {
                    j = 0;
                    i++;
                }
                else
                {
                    j = prefixTable[j - 1];
                }
            }

            return result;
        }

        private int[] GeneratePrefixTable(string pattern)
        {
            var prefixTable = new int[pattern.Length];
            var i = 0;
            var j = 1;
            var currentCount = 0;
            while (j < pattern.Length)
            {
                if (pattern[j] == pattern[i])
                {
                    i++;
                    currentCount = currentCount + 1;
                    prefixTable[j] = currentCount;
                }
                else
                {
                    i = 0;
                    currentCount = 0;
                    prefixTable[j] = 0;
                }
                j++;
            }

            return prefixTable;
        }
    }
}
