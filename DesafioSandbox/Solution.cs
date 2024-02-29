using System.Linq;
public class Solution
{
    public static string LongestPalindrome(string s)
    {
        string res = "";
        //caso ache uma letra repetida
        char[] chars = s.ToCharArray();
        for (int i = 0; i < chars.Length; i++)
        {
            List<int> rep = FindRepeated(chars, i);
            if (rep.Any())
            {
                for (int item = rep.Count - 1; item >= 0; item--)
                {
                    //Pega cada substring entre duas repetições e se caso seja palíndromo e seu tamanho seja maior que res, ele substitui res.
                    var currSubstring = chars.ToList<char>().Skip(i).Take(rep[item] - i + 1).ToArray();
                    if (isPalindrome(currSubstring))
                    {
                        string str = new string(currSubstring);
                        if (str.Length > res.Length) { res = str; }
                        break;
                    }
                }

            }
        }
        if (res == "") { return chars[0].ToString(); }
        return res;
    }
    private static bool isPalindrome(char[] chars)
    {
        int leng;
        if (chars.Length % 2 == 1)
        {
            leng = (chars.Length - 1) / 2;
        }
        else { leng = chars.Length / 2; }
        for (int i = 0; i < leng; i++)
        {
            if (chars[i] != chars[^(i + 1)])
            {
                return false;
            }
        }
        return true;
    }
    private static List<int> FindRepeated(char[] chars, int Index)
    {
        char c = chars[Index];
        List<int> res = new List<int>();
        for (int i = Index + 1; i < chars.Length; i++)
        {
            if (chars[i] == c)
            {
                res.Add(i);
            }
        }
        return res;
    }
}