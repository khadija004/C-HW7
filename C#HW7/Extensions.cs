using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_HW7
{
    internal static class Extensions
    {
        //public static bool CustomContains(this string input, string search)
        //{
        //    string check = input.ToLower();
        //    search = search.ToLower();
        //    char[] letters = check.ToCharArray();
            

        //    int wordLength = search.Length;
        //    bool output = false;

        //    for (int i = 0; i < letters.Length; i++)
        //    {
        //        if (letters[i] == search[0])
        //        {
        //            string result = new string(letters, i, wordLength);
        //            if (result == search)
        //            {
        //                output = true;
        //                break;
                        
        //            }
        //        }
        //    }
        //    return output;


        //}


        public static void CustomSplit(this string sentence,char input)
        {
            char[]letter=sentence.ToCharArray();
            char[] tempLetter = new char[0];
            string[]result = new string[0];
            


            for (int i = 0; i < letter.Length; i++)
            {
                if (letter[i] != input)
                {
                    Array.Resize(ref tempLetter,tempLetter.Length+1);
                    tempLetter[tempLetter.Length-1] = letter[i];
                }
                else
                {
                    string word = new string(tempLetter);
                    Array.Resize(ref result,result.Length+1);
                    result[result.Length-1] = word;
                    tempLetter = new char[0];
                }
            }
            if (tempLetter.Length > 0)
            {
                string word = new string(tempLetter);
                Array.Resize(ref result, result.Length + 1);
                result[result.Length - 1] = word;
            }


            foreach (string output in result)
            {
                Console.WriteLine(output);
            }
        }
    }
}
