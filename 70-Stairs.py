class Solution:
    def climbStairs(self, n: int) -> int:
        dp = [None] * (n + 1)
        dp[0] = 1
        dp[1] = 1

        for step in range(2, n + 1):
            steps = dp[step - 1] + dp[step - 2]
            dp[step] = steps
        
        return dp[n]