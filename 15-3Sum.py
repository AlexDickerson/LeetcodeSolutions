class Solution:
    def threeSum(self, nums: List[int]) -> List[List[int]]:
        numsDict = {}
        usedNums = set()
        triplets = set()

        for i, num in enumerate(nums): #o(n)
            if num not in numsDict: numsDict[num] = [i]
            else: numsDict[num].append(i)
        
        for i, num in enumerate(nums):
            if(num in usedNums): continue

            for j, rove in enumerate(nums):
                if(i == j): continue

                diff = (num + rove) * -1
                if(diff in numsDict): 
                    if(numsDict[diff][0] == i or numsDict[diff][0] == j): 
                        continue

                    triplets.add(tuple(sorted([nums[i], nums[j], nums[numsDict[diff][0]]]))) 

                    usedNums.add(num)

        return triplets