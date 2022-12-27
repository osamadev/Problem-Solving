// 623. Add One Row to Tree
// https://leetcode.com/problems/add-one-row-to-tree/description/

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
    public TreeNode AddOneRow(TreeNode root, int val, int depth) {
        // Get left subtree & right subtree in level = depth-1
        // Keep track of the parent node at level "depth-1" 
        // Create two tree nodes with value "val"
        // set parnet node left and right pointers to the new nodes
        // set the left pointer of the left subtree to the left new node
        // same for the right subtree
        if(depth == 1){
            TreeNode newRoot = new TreeNode(val);
            newRoot.left = root;
            return newRoot;
        }
        List<TreeNode> list = new List<TreeNode>();
        GetParentNode(root, depth-1, list);
        foreach(var parent in list){
            var leftSubtree = parent.left;
            var rightSubtree = parent.right;
            TreeNode leftNode = new TreeNode(val);
            leftNode.left = leftSubtree;
            TreeNode rightNode = new TreeNode(val);
            rightNode.right = rightSubtree;
            parent.left = leftNode;
            parent.right = rightNode;
        }
        
        return root;
    }

    private void GetParentNode(TreeNode root, int depth, List<TreeNode> list){
        if(root == null) return;
        if(depth == 1)
            list.Add(root);
        GetParentNode(root.left, depth-1, list);
        GetParentNode(root.right, depth-1, list);
    }
}