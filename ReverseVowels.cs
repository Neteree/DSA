public class Solution {
    public string ReverseVowels(string s) {
        char[] result = s.ToCharArray();
        char[] vowels = ['a', 'A', 'e', 'E', 'i', 'I', 'o', 'O', 'u', 'U'];
        int leftIndex = 0;
        int rightIndex = s.Length - 1;

        while(leftIndex < rightIndex) { 
            if(!vowels.Contains(s[leftIndex])) {
                leftIndex++;
            }
            else if(!vowels.Contains(s[rightIndex])) {
                rightIndex--;
            }
            else {
                result[leftIndex] = s[rightIndex];
                result[rightIndex] = s[leftIndex];

                leftIndex++;
                rightIndex--; 
            }
        }

        return new string(result);
    }
}
