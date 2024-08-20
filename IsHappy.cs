public class Solution {
    private int SumSquares(int n) {
        int sum = 0;

        while (n != 0) {
            sum += (n % 10) * (n % 10);
            n /= 10;
        }

        return sum;
    }
    
    public bool IsHappy(int n) {
        int slow = n;
        int fast = n;

        do {
            slow = SumSquares(slow);
            fast = SumSquares(SumSquares(fast));
        } while (slow != fast);

        return fast == 1;
    }
}
