namespace LeetCode;

internal class RomanNumerals
{
    public int RomanToInt(string roman)
    {
        Dictionary<char, int> romanMap = new Dictionary<char, int>()
    {
        {'I', 1},
        {'V', 5},
        {'X', 10},
        {'L', 50},
        {'C', 100},
        {'D', 500},
        {'M', 1000}
    };
        int total = 0;
        for (int i = 0; i < roman.Length; i++)
        {
            if (i + 1 < roman.Length && romanMap[roman[i]] < romanMap[roman[i + 1]])
            {
                total -= romanMap[roman[i]];
            }
            else
            {
                total += romanMap[roman[i]];
            }
        }
        return total;
    }

}
