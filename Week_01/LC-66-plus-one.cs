public class Solution {
    public int[] PlusOne(int[] digits) {
        for(int i= digits.Count() -1; i = 0; i--)
        {
            digits[i]++;
            if(digits[i] == 10)
            {
                digits[i] = 0;
            }
            else
            {
                return digits;
            }
        }

        var newDigitsWithHigherNum = new int[digits.Count()+1];
        newDigitsWithHigherNum[0] = 1;
        
        return newDigitsWithHigherNum; 
    }
}