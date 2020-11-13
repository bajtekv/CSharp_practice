using System;

namespace kata1
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("[{0}]", string.Join(", ", StringSplit("ahojda")));
            Console.WriteLine("[{0}]", string.Join(", ", StringSplit("liska")));
            Console.ReadLine();
        }
        public static string[] StringSplit(string str)
        {
            bool odd = false;
            int a;
            if (str.Length % 2 == 0)
            {
                a = str.Length / 2;
            }
            else
            {
                a = (str.Length + 1) / 2;
                odd = true;
            }
            string[] resultArray = new string[a];
            int k = 0;
            string tmp = "";
            for (int i = 0; i < str.Length; i++)
            {
                tmp += str[i];
                if (i % 2 != 0)
                {
                    resultArray[k] = tmp;
                    k += 1;
                    tmp = "";
                }
                if (i == str.Length - 1 && odd)
                {
                    resultArray[k] += str[i];
                    resultArray[k] += "_";
                }
            }
            return resultArray;
        }
    }
}
