# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, x):
#         self.val = x
#         self.next = None

class Solution:
    def hasCycle(self, head: Optional[ListNode]) -> bool:
        if(not head): return False
        if(not head.next): return False

        fastPointer = head
        slowPointer = head

        while(fastPointer and fastPointer.next):
            fastPointer = fastPointer.next.next
            slowPointer = slowPointer.next

            if(fastPointer == slowPointer): return True

        return False        