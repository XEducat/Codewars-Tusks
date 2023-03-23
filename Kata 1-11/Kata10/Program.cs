
/*
 6 kyu | Find the odd int
 https://www.codewars.com/kata/54da5a58ea159efa38000836
*/
namespace Solution
{
    class Kata
    {
        public static int find_it(int[] seq)
        {
            int found = 0;

            foreach (var num in seq)
            {
                found ^= num;
            }

            return found;
        }

    }
}
