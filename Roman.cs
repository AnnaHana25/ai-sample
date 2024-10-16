public class Solution {
/// <summary>
    /// Converts a Roman numeral string to its integer value.
    /// </summary>
    /// <param name="s">The Roman numeral string to convert.</param>
    /// <returns>The integer value of the Roman numeral.</returns>
        public int RomanToInt(string s) {
        Dictionary<char, int> romanValues = new Dictionary<char, int>
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
        int prevValue = 0;

        for (int i = s.Length - 1; i >= 0; i--)
        {
            int currentValue = romanValues[s[i]];
            if (currentValue >= prevValue)
            {
                total += currentValue;
            }
            else
            {
                total -= currentValue;
            }
            prevValue = currentValue;
        }

        return total;
    }
}