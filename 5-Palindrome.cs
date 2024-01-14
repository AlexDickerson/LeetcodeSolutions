class Solution:
    def LargestForIndex(self, s: str, i: int) -> str:
        leftFence = i - 1
        rightFence = i + 1
        length = 1

        candidate = ""

        while(rightFence < len(s) and s[i] == s[rightFence]):
            rightFence += 1
            if(rightFence == len(s) or s[i] != s[rightFence]): 
                rightFence -= 1
                break

        candidate = s[i:rightFence+1:1]
        rightFence = i + 1
        if(len(candidate) == 2 and candidate[0] != candidate[1]): candidate = ""

        while(leftFence >= 0 and rightFence < len(s)):
            if(s[leftFence] == s[rightFence]): 
                if(len(s[leftFence:rightFence+1:1]) > len(candidate)): candidate = s[leftFence:rightFence+1:1]
                rightFence += 1
                leftFence -= 1
            else:
                break

        possible = ""
        if((i < len(s)- 1) and s[i] == s[i+1]): possible = self.LargestForTwoIndices(s, i, i+1)
        if(len(possible) > len(candidate)): candidate = possible
        
        return candidate

    def LargestForTwoIndices(self, s: str, i: int, j: int) -> str:
        if(s == len(s) or j == len(s)): return ""
        if(s[i] != s[j]): return ""
        leftFence = i - 1
        rightFence = j + 1
        length = 1

        candidate = ""

        while(leftFence >= 0 and rightFence < len(s)):
            if(s[leftFence] == s[rightFence]): 
                if(len(s[leftFence:rightFence+1:1]) > len(candidate)): candidate = s[leftFence:rightFence+1:1]
                rightFence += 1
                leftFence -= 1
            else:
                break

        return candidate

    def longestPalindrome(self, s: str) -> str:
        if(len(s) == 1): return s[0]

        lIndex = 0
        lLength = 0

        longest = s[0]

        for idx, c in enumerate(s):
            candidate = self.LargestForIndex(s, idx)
            if(len(candidate) > len(longest)): longest = candidate
            
        return longest

