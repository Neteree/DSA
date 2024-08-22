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
   
    public IList<int> InorderTraversal(TreeNode root) {
        // Recursive version
        // List<int> result = new();

        // void Inorder(TreeNode root) {
        //     if(root == null) {
        //         return;
        //     }

        //     Inorder(root.left);
        //     result.Add(root.val);
        //     Inorder(root.right);
        // }

        // Inorder(root);

        // return result;

        List<int> result = new();
        Stack<TreeNode> stack = new();
        TreeNode current = root;

        while(current != null || stack.Count > 0) {
            while(current != null) {
                stack.Push(current);
                current = current.left;
            }

            current = stack.Pop();
            result.Add(current.val);
            current = current.right;
        }

        return result;
    }
}
