public class Solution {
   
    public int Search(int[] nums, int target) 
    {
        if(nums == null || nums.Length == 0) return 0;

        var left = 0;
        var right = nums.Length - 1;
        var mid = -1;

        while(left < right)
        {            
            mid = (left + right) / 2;
            Console.WriteLine(mid);
            if(nums[mid] == target) return mid;

            Console.WriteLine(nums[mid] >= target);
            Console.WriteLine(nums[left] > nums[mid]);
            Console.WriteLine(target >= nums[left]);

            if((nums[mid] >= target)^(nums[left] > nums[mid])^(target >= nums[left]))
            {
                // One true, two false => true
                left = mid + 1;                
            } 
            else
            {
                // Two true, one false => false                
                right = mid;
            }
        }

        return nums[left] == target ? left : -1;        
    } 
}