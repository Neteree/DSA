public class Solution {
    public void MoveZeroes(int[] nums) {
        int leftIndex = 0;

        for(int rightIndex = 0; rightIndex < nums.Length; rightIndex++)
        {
            if(nums[rightIndex] != 0)
            {
                int temp = nums[leftIndex];
                nums[leftIndex] = nums[rightIndex];
                nums[rightIndex] = temp;
                leftIndex++;
            }           
        }
    }
}
