public class Solution {
    public int RomanToInt(string s) {
        Dictionary<char, int> romanVals = new Dictionary<char, int>();
        romanVals.Add('I', 1);
        romanVals.Add('V', 5);
        romanVals.Add('X', 10);
        romanVals.Add('L', 50);
        romanVals.Add('C', 100);
        romanVals.Add('D', 500);
        romanVals.Add('M', 1000);
        
        var retVal = 0;
        
        var romanNums = s.ToCharArray();
        for(int i = 0; i < s.Length; i++){
            switch(romanNums[i]){
                case 'I':
                    if(i < s.Length - 1){
                        if(romanNums[i+1] == 'V' || romanNums[i+1] == 'X') retVal = retVal - romanVals['I'];
                        else retVal = retVal + romanVals['I'];
                    }
                    else retVal = retVal + romanVals['I'];
                    break;
                case 'X':
                    if(i < s.Length - 1){
                        if(romanNums[i+1] == 'L' || romanNums[i+1] == 'C') retVal = retVal - romanVals['X'];
                        else retVal = retVal + romanVals['X'];
                    }
                    else retVal = retVal + romanVals['X'];
                    break;
                case 'C':
                    if(i < s.Length - 1){
                        if(romanNums[i+1] == 'D' || romanNums[i+1] == 'M') retVal = retVal - romanVals['C'];
                        else retVal = retVal + romanVals['C'];
                    }
                    else retVal = retVal + romanVals['C'];
                    break;
                default:
                    retVal = retVal + romanVals[romanNums[i]];
                    break;
            }
        }
        
        return retVal;

    }
}