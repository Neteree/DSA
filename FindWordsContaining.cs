public class Solution {
    public IList<int> FindWordsContaining(string[] words, char x) {
        List<int> indices = [];

        for(int i = 0; i < words.Length; i++) {
            foreach(char character in words[i]) {
                if(character == x) {
                    indices.Add(i);
                    break;
                }
            }
        }

        return indices;
    }
}
