学习笔记

#Binary Search

### Thinking: Find the drop down number's index in a Rotated Sorted Array.
E.g.Given [4,5,6,7,0,1,2]. The drop down number is 0 , return index 4.

```C#
public class Solution {
   
    public int Search(int[] nums) 
    {
        var left = 0;
        var right = nums.Length - 1;
        var mid = -1;

        while(left < right)
        {
            mid = (left + right) / 2;
            if(mid >= 1 && nums[mid-1] > nums[mid]) return mid;
            if(nums[left] > nums[mid] && nums[mid] < nums[right])
            {
                right = mid;
            } 
            else
            {
                left = mid;
            }
        }   

        return mid; 
    } 
}
```