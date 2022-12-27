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
        List<int> list = new List<int>();
        TraverseTree(root, list);
        HashSet<int> seen = new HashSet<int>();
        for(int i=0; i < list.Count; i++){
            int complement = k - list[i];
            if(!seen.Add(complement)){
                return true;
            }
            seen.Add(list[i]);
        }
        return false;
    }
    public void TraverseTree(TreeNode root, List<int> list) {
        if(root == null) return;
        list.Add(root.val);
        TraverseTree(root.left, list);
        TraverseTree(root.right, list);
    }
}