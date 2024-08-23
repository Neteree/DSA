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
    private int GetSideDepth(TreeNode root, bool isLeft) {
        int depth = 0;

        while(root != null) {
            root = isLeft ? root.left : root.right;
            depth++;
        }

        return depth;
    }

    public int CountNodes(TreeNode root) {
        int leftDepth = GetSideDepth(root, true);
        int rightDepth = GetSideDepth(root, false);

        if(leftDepth == rightDepth) {
            return Convert.ToInt32(Math.Pow(2, leftDepth) - 1);
        }
        
        return 1 + CountNodes(root.left) + CountNodes(root.right); 
    }
}
