public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        int subStrLength = 0;
        int index = -1;
        bool inc = true;
        foreach(char c in strs[0]){
            index++;
            foreach(string s in strs){
                if(index < s.Length){
                    if(s[index] != c) inc = false;
                }
                else inc = false;
            }
            if(inc == true) subStrLength++;
        }
        return strs[0].Substring(0, subStrLength);
    }
}