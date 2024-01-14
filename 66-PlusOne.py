class Solution:
    def plusOne(self, digits: List[int]) -> List[int]:
        l = len(digits)

        p1 = l - 1
        if(digits[p1] == 9): digits[p1] = 0
        else: 
            digits[p1] = digits[p1] + 1
            return digits

        if(digits[p1] != 0): return digits
        
        while(p1 > 0):
            p1 = p1 - 1
            if(digits[p1] == 9): digits[p1] = 0
            else: 
                digits[p1] = digits[p1] + 1
                return digits
        
        digits.insert(0, 1)
        return digits
