public class Solution {
    public string ReversePrefix(string word, char ch) {
        char[] result = word.ToCharArray();
        
        for(int i = 0; i < word.Length ; i++) {
          if(word[i] == ch) {
            for(int j = i; j >= 0; j--){
                result[i - j] = word[j];
            }

            break;
          }
        }

        return new string(result);
    }
}
