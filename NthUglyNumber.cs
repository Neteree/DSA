public class Solution {
    public int NthUglyNumber(int n) {
        List<int> nums = [1];
        int i2 = 0;
        int i3 = 0;
        int i5 = 0;

        for(int i = 1; i < n; i++) {
            int minNum = Math.Min(Math.Min(nums[i2] * 2, nums[i3] * 3), nums[i5] * 5);
            nums.Add(minNum);

            if (minNum == nums[i2] * 2) {
                i2++;
            }
            if (minNum == nums[i3] * 3) {
                i3++;
            }
            if (minNum == nums[i5] * 5) {
                i5++;
            }
        }
      
      return nums[n - 1];
    } 
}
