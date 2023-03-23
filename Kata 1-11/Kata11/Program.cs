using System.Collections.Generic;

/*
 6 kyu | Split Strings
 https://www.codewars.com/kata/515de9ae9dcfc28eb6000001
*/
public class SplitString
{
    public static string[] Solution(string str)
    {
        if (str.Length % 2 != 0) str += '_';

        List<string> splitStrings = new List<string>();

        for (int i = 0; i < str.Length; i += 2)
        {
            splitStrings.Add(str[i].ToString() + str[i + 1]);
        }

        return splitStrings.ToArray();
    }
}