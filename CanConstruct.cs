public class Solution {
    public bool CanConstruct(string ransomNote, string magazine) {
        Dictionary<char, int> letterCount = new();

        foreach(char letter in magazine) {
            if(!letterCount.ContainsKey(letter)) {
                letterCount[letter] = 1;
            } 
            else {
                letterCount[letter]++;
            }
        }

        foreach(char letter in ransomNote) {
            if(letterCount.ContainsKey(letter) && letterCount[letter] > 0){
                letterCount[letter]--;
            }
            else {
                return false;
            }
        }

        return true;
    }
}
