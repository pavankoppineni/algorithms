using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.PatternSearching.KMPAlgorithm
{
    /// <summary>
    /// https://www.geeksforgeeks.org/kmp-algorithm-for-pattern-searching/
    /// </summary>
    public class KMPAlgorithm_V1
    {
        public int PatternExists(string text, string pattern)
        {
            var foundIndex = -1;
            var lps = CalculateLPS(pattern);
            var textIndex = 0;
            var patternIndex = 0;
            while (textIndex < text.Length)
            {
                //Case 1 : When textIndex and patternIndex are equal
                if (text[textIndex] == pattern[patternIndex])
                {
                    textIndex += 1;
                    patternIndex += 1;
                    if (patternIndex == pattern.Length)
                    {                        
                        foundIndex = textIndex - pattern.Length;
                        break;
                    }
                    continue;
                }
                if(patternIndex == 0)
                {
                    textIndex += 1;
                }
                else
                {
                    patternIndex = lps[patternIndex - 1];
                }
            }
            return foundIndex;
        }

        private int[] CalculateLPS(string pattern)
        {
            var lps = new int[pattern.Length];
            lps[0] = 0;
            var suffixIndex = 1;
            var prefixIndex = 0;
            while (suffixIndex < pattern.Length)
            {
                //Case 1 : When suffix index and prefix index are equal
                if (pattern[suffixIndex] == pattern[prefixIndex])
                {
                    prefixIndex++;
                    lps[suffixIndex] = prefixIndex;
                    suffixIndex++;
                    continue;
                }

                if (prefixIndex == 0)
                {
                    suffixIndex += 1;
                }
                else
                {
                    prefixIndex = lps[prefixIndex - 1];
                }
            }

            return lps;
        }
    }
}
