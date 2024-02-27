using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace DesafioSandbox.Solution
{
    public class Solution
    {

        public static int MyAtoi(string s)
        {
            string res = "";
            bool numStart = false;
            bool negative = false;
            for (int i = 0; i < s.Length; i++)
            {
                bool parsed = int.TryParse(s[i].ToString(), out int num);
                if (parsed) { numStart = true; }
                // Caso esteja no começo e não seja um número
                if (!numStart)
                {
                    if (s[i] == ' ') { continue; }
                    if (s[i] == '+') { numStart = true; continue; }
                    else if (s[i] == '-') { negative = true; numStart = true; continue; }
                    else { break; }
                }
                if (!parsed) { break; }
                res += num.ToString();
            }
            if (res == "") { return 0; }
            bool intParsed = int.TryParse(res, out int intRes);
            if (!intParsed)
            {
                return (negative ? int.MinValue : int.MaxValue);
            }
            return intRes * (negative ? -1 : 1);





            // string res = "";
            // int signal = 0;
            // for (int i = 0; i < s.Length && signal < 2; i++)
            // {
            //     int.TryParse(s[i].ToString(), out int c);
            //     if (c != 0)
            //     {
            //         res += s[i];
            //     }
            //     else if (s[i] == '-')
            //     {
            //         signal++;
            //     }
            //     else if (s[i] == ' ' || s[i] == '+')
            //     {
            //         continue;
            //     }
            //     else
            //     {
            //         break;
            //     }
            // }
            // if (res == "") { return 0; }
            // if (long.Parse(res) > (long)int.MaxValue)
            // {
            //     if (signal % 2 == 0) { return int.MaxValue; }
            //     return int.MinValue;
            // }
            // return int.Parse(res) * (signal % 2 == 0 ? 1 : -1);
        }
    }
}