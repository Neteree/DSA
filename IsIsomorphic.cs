public class Solution {
    public bool IsIsomorphic(string s, string t) {        
        Dictionary<char, char> sToT = new(), tToS = new();
        
        for (int i = 0; i < s.Length; i++)
        {
            if (sToT.ContainsKey(s[i]) && sToT[s[i]] != t[i] || tToS.ContainsKey(t[i]) && tToS[t[i]] != s[i])
            {
                return false;
            }
          
            sToT[s[i]] = t[i];
            tToS[t[i]] = s[i];
        }
        
        return true;
    }
}
