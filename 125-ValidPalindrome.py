class Solution:
    def isPalindrome(self, s: str) -> bool:
        lenS = len(s)
        if(lenS == 1): return True

        p1 = 0
        p2 = lenS - 1

        while(p1 <= p2):
            while(not s[p1].isalnum()): 
                p1 += 1
                if(p1 == lenS): return True
            while(not s[p2].isalnum()): 
                p2 -= 1
                if(p2 == 0): return True
                
            if(s[p1].lower() != s[p2].lower()): return False

            p1 += 1
            p2 -= 1

        return True