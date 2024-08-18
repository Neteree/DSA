public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        Dictionary<int, int> numsIndices = new();

        for (int i = 0; i < nums.Length; i++) {
            if (numsIndices.ContainsKey(nums[i]) && i - numsIndices[nums[i]] <= k) {
                    return true;
            }

            numsIndices[nums[i]] = i;
        }
        
        return false;
    }
}
