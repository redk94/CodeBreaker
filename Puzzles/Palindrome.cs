using System;

namespace Puzzles
{
    public class Palindrome
    {
        public void RunSample()
        {
            CheckPalindrome("aba");
            CheckPalindrome("abba");
            CheckPalindrome("abcba");
            CheckPalindrome("aaa");
            CheckPalindrome("acba");
            CheckPalindrome("abcda");
            CheckPalindrome("abbdkskdbba");
            CheckPalindrome("abbdkKdbba");
            CheckPalindrome("abbdcbba");
        }

        private void CheckPalindromeFor(string input)
        {
            input = input.ToLower();

            int maxIdx = (input.Length - 1);
            int leftEndIndex = maxIdx / 2;

            bool isPalindrome = true;

            for (int left = 0; left <= leftEndIndex; left++)
            {
                int right = maxIdx - left;

                if (input[left] == input[right])
                    continue;

                Console.WriteLine(input[left] + " != " + input[right]);
                isPalindrome = false;
            }

            Console.WriteLine(input + " is palidorom? " + isPalindrome);
        }

        private void CheckPalindrome(string input)
        {
            int min = 0;
            int max = input.Length - 1;

            input = input.ToLower();

            bool isPalindrome = true;
            while (true)
            {
                if (min > max)
                    break;

                if (char.ToLower(input[min]) != char.ToLower(input[max]))
                {
                    isPalindrome = false;
                    Console.WriteLine(input[min] + " != " + input[max]);
                    break;
                }

                max--;
                min++;
            }

            Console.WriteLine(input + " is palidorom? " + isPalindrome);
        }
    }
}
