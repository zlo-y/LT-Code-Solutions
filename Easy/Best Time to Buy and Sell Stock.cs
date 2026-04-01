public class Solution {
    public int MaxProfit(int[] prices) {
        int minPrice = 0;
        int maxPrice = 0;

        for(int right = 1; right < prices.Length; right++){
            if(prices[minPrice] < prices[right]){
                int currentProfit = prices[right] - prices[minPrice];
                if(currentProfit > maxPrice){
                    maxPrice = currentProfit;
                }
            }
            else{
                minPrice = right;
            }
        }
        return maxPrice;
    }
}
