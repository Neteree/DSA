public class Solution {
    public int CalPoints(string[] operations) {     
        Stack<int> scores = new();

        foreach(string operation in operations)
        {
                if (operation == "+") {
                    int lastScore = scores.Pop();
                    int secondLastScore = scores.Peek();

                    scores.Push(lastScore);
                    scores.Push(lastScore + secondLastScore);
                }
                else if (operation == "D") {
                    scores.Push(2 * scores.Peek());
                }
                else if (operation == "C") {
                    scores.Pop();  
                }
                else {
                    scores.Push(Convert.ToInt32(operation));
                } 
            
        }

        return scores.Sum();
    }
}
