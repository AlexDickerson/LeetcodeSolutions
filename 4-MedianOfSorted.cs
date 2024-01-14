public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        int[] testArr = nums1.Concat(nums2).ToArray();
        Array.Sort(testArr);
        return ExtractMedian(testArr);
    }

    private double ExtractMedian(int[] arr){
        if(arr.Length%2 == 0){
            int med1 = arr[arr.Length/2 - 1];
            int med2 = arr[arr.Length/2];
            return (double)((double)(med1 + (double)med2) / 2);
        }
        else {
            return arr[arr.Length/2];
        }
    }
}