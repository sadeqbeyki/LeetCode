namespace LeetCode;

internal class LongestSubstring
{
    public int LengthOfLongestSubstring(string word)
    {
        Dictionary<char, int> charIndex = [];
        int left = 0;
        int maxLength = 0;

        for (int right = 0; right < word.Length; right++)
        {
            char currentChar = word[right];
            if (charIndex.ContainsKey(currentChar) && charIndex[currentChar] >= left)
            {
                left = charIndex[currentChar] + 1;
            }
            charIndex[currentChar] = right;
            maxLength = Math.Max(maxLength, right - left + 1);
        }

        return maxLength;
    }

}
