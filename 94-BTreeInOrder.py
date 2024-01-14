# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right
class Solution:
    def navigateTree(self, node: TreeNode) -> List[int]:
        order = list()
        if(not node.left and not node.right): 
            order.append(node.val)
            return order

        if(node.left): 
            order = order + (self.navigateTree(node.left))

        order.append(node.val)
        
        if(node.right): 
            order = order + (self.navigateTree(node.right))

        return order
        
    def inorderTraversal(self, root: Optional[TreeNode]) -> List[int]:
        order = []
        if(not root): return order
        
        if(root.left): 
            order = order + (self.navigateTree(root.left))

        order.append(root.val)