using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.PatternMatching.KmpAlgorithm
{
    public class KmpAlgorithmImplementation
    {
        private readonly string text;

        public KmpAlgorithmImplementation(string text)
        {
            this.text = text;
        }

        public bool Match(string pattern)
        {
            var result = false;
            var longestPrefixToSufix = CalculateLongestPrefixToSufixArray(pattern);
            var textPointer = 0;
            var patternPointer = 0;
            while (textPointer < text.Length)
            {
                if (text[textPointer] == pattern[patternPointer])
                {
                    patternPointer++;
                    textPointer++;
                }
                else
                {
                    if (patternPointer > 0)
                    {
                        patternPointer = longestPrefixToSufix[patternPointer - 1];
                    }
                    else
                    {
                        patternPointer = 0;
                        textPointer++;
                    }
                }
                if (patternPointer >= pattern.Length)
                {
                    result = true;
                    break;
                }
            }
            return result;
        }

        private int[] CalculateLongestPrefixToSufixArray(string pattern)
        {
            var longestPrefixToSufixArray = new int[pattern.Length];
            if (pattern.Length == 1)
            {
                return longestPrefixToSufixArray;
            }

            var i = 0;
            var j = 1;
            while (j < pattern.Length)
            {
                if (pattern[i] == pattern[j])
                {
                    i++;
                    longestPrefixToSufixArray[j] = i;
                }
                else
                {
                    i = 0;
                }
                j++;
            }
            return longestPrefixToSufixArray;
        }
    }
}
