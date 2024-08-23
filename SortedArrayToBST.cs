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
    public TreeNode SortedArrayToBST(int[] nums) {
        TreeNode Helper(int left, int right) {
            if(left > right) {
                return null;
            }
 
            int mid = (left + right) / 2;
            TreeNode root = new(nums[mid]);
            root.left = Helper(left, mid - 1);
            root.right = Helper(mid + 1, right);

            return root;
        }

        return Helper(0, nums.Length - 1);
    }
}
