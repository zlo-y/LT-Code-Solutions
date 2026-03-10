public class Solution {
    public int MaxArea(int[] height) {
        int maxWater = 0;
        int left = 0;
        int right = height.Length - 1;

        while(left < right){
            int widht = right - left;
            int currentHeight = Math.Min(height[left] , height[right]);
            int currentWater = widht * currentHeight;


            if(currentWater > maxWater){
                maxWater = currentWater;
            }

            if(height[left] < height[right]){
                left++;
            }
            else{
                right--;
            }
            
        }
        return maxWater;

    }
}
