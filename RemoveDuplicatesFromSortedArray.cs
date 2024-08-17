public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int leftIndex = 1;
        
        for(int rightIndex = 1; rightIndex < nums.Length; rightIndex++) {
            if(nums[rightIndex] != nums[rightIndex - 1]) {
                nums[leftIndex] = nums[rightIndex];
                leftIndex++;
            }
        }
        
        return leftIndex;
    }
}
