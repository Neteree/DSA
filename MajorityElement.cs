public class Solution {
    public int MajorityElement(int[] nums) {
        Dictionary<int, int> occurrences = new();
        int majorityElement = nums[0];

        for(int i = 0; i < nums.Length; i++) {
            if(!occurrences.ContainsKey(nums[i])) {
                occurrences[nums[i]] = 0;
            }
            else {
                occurrences[nums[i]]++;
            }

            if(occurrences[nums[i]] > occurrences[majorityElement]) {
                majorityElement = nums[i];
            }
        }

        return majorityElement;
    }
}
