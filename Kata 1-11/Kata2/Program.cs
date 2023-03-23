
/*
 8 kyu | Abbreviate a Two Word Name 
 https://www.codewars.com/kata/57eadb7ecd143f4c9c0000a3
*/

public class Kata
{
    public static string AbbrevName(string name)
    {
        int spaceIndex = name.IndexOf(" ");

        return $"{name[0]}.{name[name.IndexOf(' ') + 1]}".ToUpper();
    }
}