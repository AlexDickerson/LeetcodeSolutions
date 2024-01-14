class Solution:
    def mySqrt(self, x: int) -> int:
        if(x == 0): return 0
        if(x == 1): return 1
        if(x == 2): return 1

        c = x / 2

        if(c * c == x): return floor(c)

        while(c * c > x): c = c / 1.02

        for i in range(floor(c), x):
            if(i * i <= x): c = i
            else: break

        return floor(c)