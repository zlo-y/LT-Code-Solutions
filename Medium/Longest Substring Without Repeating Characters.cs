public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int left = 0;
        int maxAnswer = 0;

        var set = new HashSet<char>();

        for(int rigth = 0; rigth < s.Length; rigth++){
            while(set.Contains(s[rigth])){
                set.Remove(s[left]);
                left++;
            }
            set.Add(s[rigth]);
            int currentAnswer = rigth - left + 1;
            if(currentAnswer > maxAnswer){
                maxAnswer = currentAnswer;
            }
        }
        return maxAnswer;

    }
}
