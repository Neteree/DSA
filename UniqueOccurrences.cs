public class Solution {
    public bool UniqueOccurrences(int[] arr) {
        Dictionary<int, int> occurrences = new();

        foreach(int num in arr) {
            if(!occurrences.ContainsKey(num)) {
                occurrences[num] = 1;
            }
            else {
                occurrences[num]++;
            }
        }

        HashSet<int> uniqueOccurrences = new(occurrences.Values);

        return occurrences.Count == uniqueOccurrences.Count;
    }
}
