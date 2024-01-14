class Solution:
    def isPalindrome(self, x: int) -> bool:
        numStr = str(x) #O(2log(n))

        if(len(numStr) == 1): return True

        p1 = 0
        p2 = len(numStr) - 1

        #O(n/2)
        while(numStr[p1] == numStr[p2]):
            if(p1 == p2): return True
            if(p1 == p2 - 1): return True
            p1 += 1
            p2 -= 1
        
        #O(2log(n) + n/2)
        return False