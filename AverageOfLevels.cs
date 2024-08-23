/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public IList<double> AverageOfLevels(TreeNode root) {
        List<Double> avgList = new();
        Queue<TreeNode> levelQueue = new();
        levelQueue.Enqueue(root);
        levelQueue.Enqueue(null);

        while(levelQueue.Peek() != null) {
            double sum = 0;
            int nodeAmount = 0;
            
            while(levelQueue.Peek() != null) {
                TreeNode node = levelQueue.Dequeue();
                sum += node.val;
                nodeAmount++;

                if(node.left != null) {
                    levelQueue.Enqueue(node.left);
                }

                if(node.right != null) {
                    levelQueue.Enqueue(node.right);
                }
            }

            levelQueue.Enqueue(levelQueue.Dequeue());
            avgList.Add(sum / nodeAmount);

        }

        return avgList;
    }
}
