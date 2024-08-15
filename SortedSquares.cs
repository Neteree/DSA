public class Solution {
    public int[] SortedSquares(int[] nums) {
        int leftIndex = 0;
        int rightIndex = nums.Length - 1;
        int[] result = new int[nums.Length];

        for(int i = rightIndex; i > -1; i--){
            if(Math.Abs(nums[leftIndex]) > Math.Abs(nums[rightIndex])) {
                result[i] = nums[leftIndex] * nums[leftIndex];
                leftIndex++;
            } else{
                result[i] = nums[rightIndex] * nums[rightIndex];
                rightIndex--;
            }
        }
        
        return result;
    }
}
