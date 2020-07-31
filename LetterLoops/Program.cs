using System;
using System.Linq;

namespace LetterLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me some letters");

            var readThis = Console.ReadLine();

            char[] lettersArr = readThis.ToCharArray();

            var finalCharList = lettersArr.Select(c => c.ToString()).ToArray();

            for (int i = 0; i < lettersArr.Length; i++)
            {
                var singleChar = string.Join("", Enumerable.Repeat(lettersArr[i], i+1));
                finalCharList[i] = UpperCaseFirst(singleChar);
            }

            static string UpperCaseFirst(string s)
            {
                if (string.IsNullOrEmpty(s))
                {
                    return string.Empty;
                }

                char[] a = s.ToCharArray();
                a[0] = char.ToUpper(a[0]);
                return new string(a);
            }

            Console.WriteLine(string.Join('-', finalCharList));
        }
    }
}
