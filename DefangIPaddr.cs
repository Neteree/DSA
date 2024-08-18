public class Solution {
    public string DefangIPaddr(string address) {
        string defangedAddress = "";

        foreach(char character in address) {
            if(character == '.') {
                defangedAddress += "[.]";
            }
            else {
                defangedAddress += character;
            }
        }

        return defangedAddress;
    }
}
