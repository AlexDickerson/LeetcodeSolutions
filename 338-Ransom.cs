public class Solution {
    public bool CanConstruct(string ransomNote, string magazine) {
        int[] letters = new int[26];

        foreach(var letter in ransomNote.ToCharArray()){
            int index = char.ToUpper(letter) - 65;
            letters[index]++;
        }

        foreach(var letter in magazine.ToCharArray()){
            int index = char.ToUpper(letter) - 65;
            letters[index]--;
        }

        if(letters.Max() >= 1) return false;
        
        return true;
    }
}