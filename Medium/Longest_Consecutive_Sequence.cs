public class Solution {
    public int LongestConsecutive(int[] nums) {
        if(nums.Length == 0) return 0;

        int longestStreak = 0;

        var numSet = new HashSet<int>(nums);

        foreach(int num in numSet){
            if(!numSet.Contains(num - 1)){
                int currentNum = num;
                int currentStreak = 1;


                while(numSet.Contains(currentNum + 1)){
                currentNum += 1;
                currentStreak += 1;
            }

            longestStreak = Math.Max(longestStreak , currentStreak);
        }
    }
    return longestStreak;
    }
}
