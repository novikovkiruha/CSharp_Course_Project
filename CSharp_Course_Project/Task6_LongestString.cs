using System;
using System.Text;
using System.Threading;

namespace CSharp_Course_Project
{
    class Task6_LongestString
    {
        public static void LongestString()
        {
            string firstString = Task6_LongestString.GetRandomString();
            //string firstString = "xyaabbbccccdefww";
            Console.WriteLine($"First string: {firstString}");
            string secondString = Task6_LongestString.GetRandomString();
            //string secondString = "xxxxyyyyabklmopq";
            Console.WriteLine($"Second string: {secondString}");
            StringBuilder longestStringBuilder = Task6_LongestString.StringConcatenation(firstString, secondString);
            StringBuilder longestStringBuilderWtDuplicates = Task6_LongestString.GetStringWithoutDuplicates(longestStringBuilder);
            string longestString = Task6_LongestString.Sort(longestStringBuilderWtDuplicates);
            Console.WriteLine(longestString);
        }

        //
        // How can I make an even-changing random values?
        //
        private static string GetRandomString()
        {
            var random = new Random();
            int randomNumber = random.Next(10, 50);

            char[] chars = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            char[] randomCharArray = new char[randomNumber];

            for (int i = 0; i < randomCharArray.Length; i++)
            {
                randomCharArray[i] = chars[random.Next(chars.Length)];
            }
            string randomString = string.Join("", randomCharArray);
            Thread.Sleep(50);

            return randomString;
        }

        private static StringBuilder StringConcatenation(string firstString, string secondString)
        {
            var longestStringBuilder = new StringBuilder();
            longestStringBuilder.Append(firstString);
            longestStringBuilder.Append(secondString);

            return longestStringBuilder;
        }

        //
        // Why it is executed only once and then failed?
        //
        private static StringBuilder GetStringWithoutDuplicates(StringBuilder longestStringBuilderWtDuplicates)
        {
            for (int i = 0; i < longestStringBuilderWtDuplicates.Length; i++)
            {
                for (int j = 0; j < longestStringBuilderWtDuplicates.Length; j++)
                {
                    if (longestStringBuilderWtDuplicates[i] == longestStringBuilderWtDuplicates[j] && i != j)
                    {
                        longestStringBuilderWtDuplicates.Remove(j, 1);
                    }
                }
            }

            return longestStringBuilderWtDuplicates;
        }

        private static string Sort(StringBuilder longestStringBuilder)
        {
            var charArray = longestStringBuilder.ToString().ToCharArray();
            Array.Sort(charArray);
            var longestString = string.Join("", charArray);

            return longestString;
        }
    }
}
