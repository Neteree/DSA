public class Solution {
    public int ScoreOfString(string s) {
        int sum = 0;

        for(int i = 0; i < s.Length - 1; i++) {
            sum += Math.Abs(Convert.ToInt32(s[i] - s[i + 1]));
        }

        return sum;
    }
}
