public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        Dictionary<int, int> numFreqs = new();

        foreach(int num in nums) {
            if(!numFreqs.ContainsKey(num)) {
                numFreqs[num] = 1;
            }
            else {
                numFreqs[num]++;
            }

            if(numFreqs[num] >= 2) {
                return true;
            }
        }

        return false;
    }
}
