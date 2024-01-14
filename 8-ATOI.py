class Solution:
    def myAtoi(self, s: str) -> int:
        digits = ""
        s = s.lstrip()
        if(s == ""): return 0
        sign = s[0]

        if(sign.isdigit()): sign = ""
        elif(sign == '+' or sign == '-'):
            if(len(s) == 1): return 0
            s = s[1::]
            if(not s[0].isdigit()): return 0
        else: return 0

        for c in s:
            if(c.isdigit()): 
                digits = digits + c
            else: break

        candidate = int(sign + digits)
        if(candidate <= -2147483648): return -2147483648
        elif(candidate >= 2147483648): return 2147483647
        else: return candidate