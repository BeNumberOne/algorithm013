public class Solution {
    public int Trap(int[] height)
    {
        int i_left = 0;
        int i_right = height.Length - 1;
        int results = 0;
        int left_max = 0;
        int right_max = 0;

        while(i_left <= i_right)
        {
            left_max = Math.Max(left_max, height[i_left]);
            right_max = Math.Max(right_max, height[i_right]);
            if(left_max < right_max)
            {
                results += (left_max - height[i_left++]);                
            }
            else
            {
                results += (right_max - height[i_right--]);               
            }
        }

        return results;
    }
}