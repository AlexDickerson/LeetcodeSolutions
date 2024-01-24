# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, val=0, next=None):
#         self.val = val
#         self.next = next
class Solution:
    def removeNthFromEnd(self, head: Optional[ListNode], n: int) -> Optional[ListNode]:
        if(not head.next): return head.next

        leadNode = head
        followNode = head

        for i in range(0, n):
            if(leadNode.next == None): 
                return head.next
            leadNode = leadNode.next

        while(leadNode):
            if(not leadNode.next):
                followNode.next = followNode.next.next
                leadNode = leadNode.next
            else:
                leadNode = leadNode.next
                followNode = followNode.next

        return head