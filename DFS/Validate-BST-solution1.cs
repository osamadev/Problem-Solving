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
    public bool IsValidBST(TreeNode root) {
        return IsValidBST(root, double.MinValue, double.MaxValue);
    }

    public bool IsValidBST(TreeNode root, double minVal, double maxVal) {
        if(root == null) return true;
        if(root.val <= minVal || root.val >= maxVal) return false;
        return IsValidBST(root.left, minVal, root.val) && IsValidBST(root.right, root.val, maxVal);
    }
}