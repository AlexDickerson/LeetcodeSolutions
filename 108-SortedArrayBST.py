# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right
class Solution:
    def buildTree(self, nums: List[int]) -> Optional[TreeNode]:
        lengthNums = len(nums)

        if(lengthNums == 0): return

        headIndex = floor(lengthNums / 2)
        
        node = TreeNode(nums[headIndex])

        node.left = self.buildTree(nums[:headIndex:])
        node.right = self.buildTree(nums[headIndex+1::])
        
        return node

    def sortedArrayToBST(self, nums: List[int]) -> Optional[TreeNode]:
        return self.buildTree(nums)
