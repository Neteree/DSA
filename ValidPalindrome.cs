using System.Text.RegularExpressions;

public class Solution {
    public bool IsPalindrome(string s) {
        string convertedS = Regex.Replace(s, "[^a-zA-Z0-9]", "").ToLower();
        
        return convertedS == new string(convertedS.Reverse().ToArray());
    }
}
