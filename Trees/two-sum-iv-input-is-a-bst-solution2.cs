// 653. Two Sum IV - Input is a BST
// https://leetcode.com/problems/two-sum-iv-input-is-a-bst/description/

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
    public bool FindTarget(TreeNode root, int k) {
        return FindTargetRec(root, k, new HashSet<int>());
    }
    public bool FindTargetRec(TreeNode root, int k, HashSet<int> seen) {
        if(root == null) return false;
        if(!seen.Add(k - root.val))
            return true;
        seen.Add(root.val);
        return FindTargetRec(root.left, k, seen) || FindTargetRec(root.right, k, seen);
    }
}