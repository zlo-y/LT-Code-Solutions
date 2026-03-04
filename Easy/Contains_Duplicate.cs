public class Solution {
    public bool ContainsDuplicate(int[] nums) {
       Dictionary<int, int> map = new Dictionary<int , int>();
       for(int i = 0; i < nums.Length; i++){
        if(map.ContainsKey(nums[i])){
            return true;
        }
        map.Add(nums[i], 1);
       }
       return false;
    }
}
