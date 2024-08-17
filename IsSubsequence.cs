public class Solution {
    public bool IsSubsequence(string s, string t) {
        int sIndex = 0;
        
        for(int tIndex = 0; sIndex < s.Length && tIndex < t.Length; tIndex++) {
            if(s[sIndex] == t[tIndex]) {
                sIndex++;
            }
        }

        return sIndex == s.Length;
    }
}
