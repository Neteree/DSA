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
    public int GetMinimumDifference(TreeNode root) {
        TreeNode previous = null;
        int result = int.MaxValue;

        void dfs(TreeNode node) {
            if(node == null) {
                return;
            }

            dfs(node.left);

            if(previous != null) {
                result = Math.Min(result, node.val - previous.val);
            }

            previous = node;

            dfs(node.right);
        }

        dfs(root);

        return result;
    }
}
