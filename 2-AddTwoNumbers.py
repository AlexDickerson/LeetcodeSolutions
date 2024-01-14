# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, val=0, next=None):
#         self.val = val
#         self.next = next
class Solution:
    def addTwoNumbers(self, l1: Optional[ListNode], l2: Optional[ListNode]) -> Optional[ListNode]:
        stack1 = []
        stack2 = []

        while(l1.next):
            stack1.append(l1.val)
            l1 = l1.next
        stack1.append(l1.val)

        while(l2.next):
            stack2.append(l2.val)
            l2 = l2.next
        stack2.append(l2.val)

        stack1Str = ""
        while(len(stack1) > 0): stack1Str = stack1Str + str(stack1.pop())

        stack2Str = ""
        while(len(stack2) > 0): stack2Str = stack2Str + str(stack2.pop())

        sumStr = str(int(stack1Str) + int(stack2Str))
        sumStr = sumStr[::-1]
        print(sumStr)
        node = ListNode(int(sumStr[0]))
        firstNode = node
        for d in sumStr[1::]:
            newNode = ListNode(int(d))
            node.next = newNode
            node = newNode
        
        return firstNode