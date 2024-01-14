public class Solution {
    public int MaxArea(int[] height) {
        int leftIndex = 0;
        int rightIndex = height.Length - 1;
        
        int retMax = 0;
        int stop = 0;
        while(leftIndex != rightIndex){
            if(height[leftIndex] <= height[rightIndex]){
                int currMax = height[leftIndex] * (rightIndex - leftIndex);
                if(currMax > retMax) retMax = currMax;
                leftIndex++;
            }
            else {
                int currMax = height[rightIndex] * (rightIndex - leftIndex);
                if(currMax > retMax) retMax = currMax;
                rightIndex--;  
            } 
        }
        
        return retMax;
    }
}