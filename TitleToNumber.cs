public class Solution {
    public int TitleToNumber(string columnTitle) {
        int result = 0;

        foreach(char letter in columnTitle) {
            result = result * 26 + Convert.ToInt32(letter) - 64;       
        }

        return result;
    }
}
