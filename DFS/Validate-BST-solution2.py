# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, x):
#         self.val = x
#         self.left = None
#         self.right = None

class Solution:
    def isValidBST(self, root):
        """
        :type root: TreeNode
        :rtype: bool
        """
        return self.isValidBST_util(root)
    
    def isValidBST_util(self, node, min_val=float('-inf'), max_val=float('inf')):
        if node == None: return True
        if node.val >= max_val or node.val <= min_val:
            return False
        return self.isValidBST_util(node.left, min_val, node.val) and self.isValidBST_util(node.right, node.val, max_val)
    
    def maxVal(self, node):
        node_values = []
        traversed_nodes = [node]
        while traversed_nodes:
            current_node = traversed_nodes.pop(0)
            node_values.append(current_node.val)
            if current_node.left:
                traversed_nodes.append(current_node.left)
            if current_node.right:
                traversed_nodes.append(current_node.right)
        return max(node_values)
    
    def minVal(self, node):
        node_values = []
        traversed_nodes = [node]
        while traversed_nodes:
            current_node = traversed_nodes.pop(0)
            node_values.append(current_node.val)
            if current_node.left:
                traversed_nodes.append(current_node.left)
            if current_node.right:
                traversed_nodes.append(current_node.right)
        return min(node_values)
            
        