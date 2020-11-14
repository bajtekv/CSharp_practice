using System;

namespace kata3
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(Accumul("abdcefghijk"));
            Console.ReadKey(true);
        }
        public static string Accumul(string s)
        {
            string result = "";
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    if (j == 0)
                    {
                        result += s[i].ToString().ToUpper();
                    }
                    else
                    {
                        result += s[i];
                    }
                }
                result += "-";
            }
            result = result.Remove(result.LastIndexOf("-"));
            return result;
        }
    }
}
