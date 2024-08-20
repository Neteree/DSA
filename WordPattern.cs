public class Solution {
    public bool WordPattern(string pattern, string s) {
        string[] words = s.Split(' ');

        if(pattern.Length != words.Length) {
            return false;
        }
       
        Dictionary<char, string> letterToWord = new();
        Dictionary<string, char> wordToLetter = new();

        for(int i = 0; i < pattern.Length; i++) {
            char letter = pattern[i];
            string word = words[i];

            if(letterToWord.ContainsKey(letter) && letterToWord[letter] != word) {
               return false; 
            }

            if(wordToLetter.ContainsKey(word) && wordToLetter[word] != letter) {
               return false; 
            }

            letterToWord[letter] = word;
            wordToLetter[word] = letter;
        }

        return true;
       
    }
}
