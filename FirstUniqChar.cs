public class Solution {
    public int FirstUniqChar(string s) {

        Dictionary<char, int> chFreqs = new();

        foreach (char ch in s)
        {
            if(chFreqs.ContainsKey(ch))
            {
                chFreqs[ch]++;
            }
            else
            {
               chFreqs[ch] = 1; 
            }
        }

        foreach (char ch in chFreqs.Keys)
        {
            if(chFreqs[ch] == 1)
            {
                return s.IndexOf(ch);
            }
        }

        return -1; 
    }
}
