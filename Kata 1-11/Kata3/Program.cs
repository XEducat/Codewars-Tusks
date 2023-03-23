using System;

/*
 8 kyu | Reversed Strings
 https://www.codewars.com/kata/5168bb5dfe9a00b126000018
*/

public static class Kata
{
    public static string Solution(string str)
    {
        char[] array = str.ToCharArray();

        Array.Reverse(array);

        return new string(array);
    }
}