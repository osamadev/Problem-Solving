// 102. Binary Tree Level Order Traversal
// https://leetcode.com/problems/binary-tree-level-order-traversal/description/

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
    IList<IList<int>> res = new List<IList<int>>();
    public IList<IList<int>> LevelOrder(TreeNode root) {
        if(root == null) return res;
        return LevelOrder(root, 1);
    }

    public IList<IList<int>> LevelOrder(TreeNode root, int level) {
        if(root == null) return null;
        if(level > res.Count) res.Add(new List<int>());
        res[level-1].Add(root.val);
        LevelOrder(root.left, level+1);
        LevelOrder(root.right, level+1);
        return res;
    }
}