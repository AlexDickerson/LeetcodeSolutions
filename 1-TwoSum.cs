public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int[] retVal = new int[2];
        for(int i = 0; i < nums.Length; i++){
            for(int j = i+1; j < nums.Length; j++){
                if((nums[i]+nums[j]) == target){
                    retVal[0] = i;
                    retVal[1] = j;
                    return retVal;
                }
            }
        }
        return retVal;
    }
}