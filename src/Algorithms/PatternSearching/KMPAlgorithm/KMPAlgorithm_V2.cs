using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.PatternSearching.KMPAlgorithm
{
    /// <summary>
    /// https://www.geeksforgeeks.org/kmp-algorithm-for-pattern-searching/
    /// </summary>
    public class KMPAlgorithm_V2
    {
        public bool CheckForPattern(string text, string pattern)
        {
            var patternFound = false;
            var textIndex = 0;
            var patternIndex = 0;
            var lps = ConstructLPS(pattern);
            while (textIndex < text.Length && patternIndex < pattern.Length)
            {
                //Case One : When pattern index and text index are matched
                if (text[textIndex] == pattern[patternIndex])
                {
                    textIndex += 1;
                    patternIndex += 1;
                }
                //Case Two : When pattern index and text index do not match
                else
                {
                    if(patternIndex == 0)
                    {
                        textIndex += 1;
                    }
                    else
                    {
                        patternIndex = lps[patternIndex - 1];
                    }
                    continue;
                }

                if (patternIndex == pattern.Length)
                {
                    patternFound = true;
                    break;
                }
            }
            return patternFound;
        }

        public int[] ConstructLPS(string text)
        {
            var lpsArray = new int[text.Length];
            var i = 0;
            for(var index = 1; index < text.Length; index++)
            {
                if (text[index] == text[i])
                {
                    i++;
                    lpsArray[index] = i;
                }
                else
                {
                    i = 0;
                    if (text[index] == text[i])
                    {
                        i++;
                        lpsArray[index] = i;
                    }
                }
            }
            return lpsArray;
        }
    }
}
