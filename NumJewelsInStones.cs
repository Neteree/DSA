public class Solution {
    public int NumJewelsInStones(string jewels, string stones) {
        int result = 0;

        foreach(char stone in stones) {
            foreach(char jewel in jewels) {
                if(jewel == stone) {
                    result++;
                }
            }
        }

        return result;
    }
}
