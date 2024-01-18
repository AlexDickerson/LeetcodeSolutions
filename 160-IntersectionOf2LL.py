# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, x):
#         self.val = x
#         self.next = None

class Solution:
    def getIntersectionNode(self, headA: ListNode, headB: ListNode) -> Optional[ListNode]:
        lengthA, lengthB = 1, 1
        nodeA, nodeB = headA, headB

        while(nodeA.next): 
            lengthA += 1
            nodeA = nodeA.next
        while(nodeB.next):
            lengthB += 1
            nodeB = nodeB.next

        listAOffset, listBOffset = 0, 0

        if(lengthA > lengthB): listAOffset = lengthA - lengthB
        else:  listBOffset = lengthB - lengthA

        nodeA, nodeB = headA, headB
        
        while(listAOffset > 0):
            nodeA = nodeA.next
            listAOffset -= 1

        while(listBOffset > 0):
            nodeB = nodeB.next
            listBOffset -= 1

        while(nodeA and nodeB):
            if(nodeA is nodeB): return nodeA
            nodeA = nodeA.next
            nodeB = nodeB.next