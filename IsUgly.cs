public class Solution {
    public bool IsUgly(int n) {
        if(n <= 0) {
            return false;
        }

        foreach(int factor in new int[] {2, 3, 5}) {
            while(n % factor == 0) {
                n /= factor;
            }
        }

        return n == 1;
    }
}
