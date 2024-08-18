public class Solution 
{   
    public int RomanToInt(string s)
    {
        Dictionary<char, int> rNums = new()
        {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 }
        };

        var result = 0;

        for(int i = 0; i < s.Length; i++)
        {
           result += (i < s.Length - 1 && rNums[s[i]] < rNums[s[i + 1]]) ? -rNums[s[i]] : rNums[s[i]];
        }

        return result;
    }
}
