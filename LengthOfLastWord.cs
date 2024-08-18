public class Solution {
    public int LengthOfLastWord(string s) {
        s = s.Trim();
        int LastWordLength = 0;

        for(int i = s.Length - 1; i >= 0 && s[i] != ' '; i--) {
            LastWordLength++;
        }

        return LastWordLength;
    }
}
