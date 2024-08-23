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
    public int DiameterOfBinaryTree(TreeNode root) {
        int result = 0;

        int dfs(TreeNode current) {
            if(current == null) {
                return 0;
            }

            int left = dfs(current.left);
            int right = dfs(current.right);
            result = Math.Max(result, left + right);

            return 1 + Math.Max(left, right);
        }

        dfs(root);

        return result;
    }
}
