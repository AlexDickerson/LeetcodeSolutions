# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right
class Solution:
    def isSymmetric(self, root: Optional[TreeNode]) -> bool:
        if(not root): return True
        if(not root.left and not root.right): return True
        if(not root.left or not root.right): return False

        stack = list()
        stack.append((root.left, root.right))

        while(len(stack) > 0):
            values = stack.pop()
            if(values[0].val != values[1].val): return False

            if(values[0].left and values[1].right):
                stack.append((values[0].left, values[1].right))
            elif(values[0].left or values[1].right): return False
            
            if(values[0].right and values[1].left):
                stack.append((values[0].right, values[1].left))
            elif(values[0].right or values[1].left): return False

        return True