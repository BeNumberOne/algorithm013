public class Solution {
    public int[] TwoSum(int[] nums, int target) 
    {
        var dic = new Dictionary<int,int>();
        for (int i = 0; i < nums.Length; i++)
        {
            var expectNum = target - nums[i];
            if(dic.ContainsKey(expectNum))
            {
                return new int[] {dic[expectNum], i};
            }
            else if(!dic.ContainsKey(nums[i]))
            {
                dic.Add(nums[i], i);
            }
        }

       return new int[0];
    }
}