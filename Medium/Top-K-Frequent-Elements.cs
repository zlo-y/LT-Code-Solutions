public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var map = new Dictionary<int , int>();

        for(int i = 0; i < nums.Length; i++){
            int num = nums[i];
            if(!map.ContainsKey(num)){
                map[num] = 1;
            }
            else{
                map[num]++;
            }
        }

        List<int>[] buckets = new List<int>[nums.Length + 1];

        foreach(var count in map){
            int freq = count.Value;
            int number = count.Key;

            if(buckets[freq] == null){
                buckets[freq] = new List<int>();
            }
            buckets[freq].Add(number);
        }

        List<int> result = new List<int>();

        for(int i = buckets.Length - 1; i >= 0 && result.Count < k; i--){
            if(buckets[i] != null){
                result.AddRange(buckets[i]);
            }
            
        }
        return result.Take(k).ToArray();
    }
}
