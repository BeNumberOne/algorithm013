public class Solution
{
    public void MoveZeroes(int[] nums) 
    {
        var zeroLength = 0;

        for(int i= 0; i< nums.Count();i++)
        {
            if(nums[i] == 0)
            {
                zeroLength++;
            }
            else if(zeroLength > 0)
            {
                nums[i - zeroLength] = nums[i];
                nums[i] = 0;
            }
        }
    }
}