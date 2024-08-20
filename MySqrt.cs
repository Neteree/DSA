public class Solution {
    public int MySqrt(int x) {
        int left = 0;
        int right = x;
        int result = 0;

        while(left <= right) {
            int mid = left + ((right - left) / 2);

            if(Math.Pow(mid, 2) > x) {
                right = mid - 1;
            } 
            else if(Math.Pow(mid, 2) < x) {
                left = mid + 1;
                result = mid;
            }
            else {
                return mid;
            }
        }

        return result;
    }
}
