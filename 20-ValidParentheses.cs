public class Solution {
    public bool IsValid(string s) {
        if(s.Length == 1) return false;
        if(s.Length%2 != 0) return false;

        List<char> brackets = s.ToCharArray().ToList();
        List<char> closeBrackets = new();

        List<char> openTypes = new() { '(', '{', '[' };

        foreach(char bracket in brackets){
            if(openTypes.Contains(bracket)) {
                if(bracket == '(') closeBrackets.Add(')');
                else if(bracket == '{') closeBrackets.Add('}');
                else if(bracket == '[') closeBrackets.Add(']');
            }
            else{
                if(bracket == closeBrackets.LastOrDefault()) closeBrackets.RemoveAt(closeBrackets.Count() - 1);
                else return false;
            }
        }

        if(closeBrackets.Count() != 0) return false;

        return true;
    }
}