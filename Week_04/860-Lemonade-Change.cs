public class Solution {
    public bool LemonadeChange(int[] bills) 
    {
        if(bills == null || bills.Length == 0) return true;
        
        var five = 0;
        var ten = 0;
        for(int i= 0; i< bills.Length; i++)
        {
            if(bills[i] == 5)
            {
                five++;
            }
            else if(bills[i] == 10)
            {
                five--;
                ten++;
            }
            else 
            {
                 if(ten > 0 && five > 0)
                 {
                     ten--;
                     five--;
                 }
                 else 
                 {
                     five -= 3;
                 }
            }

            if(ten < 0 || five < 0)
            {
                return false;
            }            
        }

        return true;
    }
}