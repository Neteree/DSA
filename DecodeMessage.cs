public class Solution {
    public string DecodeMessage(string key, string message) {
        Dictionary<char, char> subTable = new();
        StringBuilder decodedMessage = new();
        int letterOffset = 0;

        foreach(char letter in key) {
            if(!subTable.ContainsKey(letter) && letter != ' ') {
                subTable[letter] = Convert.ToChar(97 + letterOffset);
                letterOffset++;
            }
        }

        foreach(char letter in message) {
            decodedMessage.Append(letter == ' ' ? ' ' : subTable[letter]);    
        }

        return decodedMessage.ToString();
    }
}
