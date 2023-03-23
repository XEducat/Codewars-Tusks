
/*
 8 kyu | DNA to RNA Conversion
 https://www.codewars.com/kata/5556282156230d0e5e000089
*/

namespace Converter
{
    public class Converter
    {
        public string dnaToRna(string dna)
        {
            return dna.Replace("T", "U");
        }
    }
}