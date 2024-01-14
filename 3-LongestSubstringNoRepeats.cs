public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int substringLength = 1;
        var cA = s.ToCharArray();
        var cHash = new Dictionary<char, int>();
        
        int currentString = 0;
        int maxString = 0;
        for(int i = 0; i < cA.Length; i++){
            if(cHash.ContainsKey(cA[i])) {
                if(currentString > maxString) {
                    maxString = currentString;
                }
                currentString = 0;
                i = cHash[cA[i]];
                cHash.Clear();
            }
            else {
                currentString++;
                cHash.Add(cA[i], i);
            }
        }
        
        return Math.Max(currentString, maxString);
    }
}