using System;

namespace CodingTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "test";

            char[] strarr = str.ToCharArray();

            char[] revarr = new char[str.Length];

            for(int i=0,j=str.Length-1; i<j; i++,j--)
            {
                strarr[i] = str[j];
                strarr[j] = str[i];
            }

            string revstring = new string(strarr);


            ///Palindrome check
            ///
            bool flag = false;
            for(int i=0,j=str.Length-1; i<str.Length/2;i++,j--)
            {
                if (str[i] != str[j])
                {
                    flag = false;
                    break;
                }
                else
                    flag = true;
            }

          ///no of occurence of character in c

        }
    }
}
