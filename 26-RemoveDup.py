class Solution:
    def removeDuplicates(self, nums: List[int]) -> int:
        length = len(nums)
        if(length == 0): return 0
        if(length == 1): return 1

        openIndex = 0

        uniqueNums = set()

        index = 0

        for num in nums:
            if(num in uniqueNums): 
                if(openIndex == 0): 
                    openIndex = nums.index(num)
                    index += 1
                    break
            else: 
                uniqueNums.add(num)
                nums[openIndex] = num
                openIndex += 1
                index += 1

        for i in range(index, length):
            if(not (num in uniqueNums)): 
                uniqueNums.add(num)
                nums[openIndex] = num
                openIndex += 1

        return len(uniqueNums)