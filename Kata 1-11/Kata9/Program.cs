
/*
 6 kyu | Count the smiley faces!
 https://www.codewars.com/kata/583203e6eb35d7980400002a
*/

public static class Kata
{
    public static int CountSmileys(string[] smileys)
    {
        string[] SmileysList = { ":)", ":D", ":-)", ":~)", ":-D", ":~D", ";)", ";D", ";-)", ";~)", ";-D", ";~D" };

        return smileys.Count(smile => SmileysList.Contains(smile));
    }
}