public class Solution {
    public int LargestRectangleArea(int[] heights) {
        var stack = new Stack<int>();
        int maxArea = 0;

        for(int i = 0; i <= heights.Length; i++){
            int currentHeight = (i == heights.Length) ? 0 : heights[i];
            while(stack.Count > 0 && currentHeight < heights[stack.Peek()]){
                int hIndex = stack.Pop();
                int h = heights[hIndex];
                int width = (stack.Count == 0) ? i : i - stack.Peek() - 1;

                maxArea = Math.Max(maxArea, h * width);
            }
            stack.Push(i);
        }
        return maxArea;
    }
}
