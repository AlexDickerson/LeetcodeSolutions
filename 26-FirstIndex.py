class Solution:
    def strStr(self, haystack: str, needle: str) -> int:
        haystackLen = len(haystack)
        needleLen = len(needle)

        if(haystack == needle): return 0

        for idx, c in enumerate(haystack):
            if(c == needle[0] and (haystackLen - idx) >= needleLen):
                if(needle == haystack[idx:idx+needleLen:1]): return idx

        return -1