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
    public IList<IList<int>> LevelOrder(TreeNode root) {
        if(root == null) return new List<IList<int>>();
        var nodesList = new List<IList<int>>();
        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        while(queue.Count > 0){
            int levelCount = queue.Count;
            var levelNodes  = new List<int>();
            while(levelCount > 0){
                var node = queue.Dequeue();
                levelNodes.Add(node.val);
                if(node.left != null)
                    queue.Enqueue(node.left);
                if(node.right != null)
                    queue.Enqueue(node.right);
                levelCount--;
            }
            nodesList.Add(levelNodes);
        }
        return nodesList;
    }
}