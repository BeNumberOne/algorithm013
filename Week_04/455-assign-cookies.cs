public class Solution 
{
    public int FindContentChildren(int[] kids, int[] cookies) 
    {
        if(kids == null || cookies == null) return 0;

        kids =  kids.OrderBy(k => k).ToArray();
        cookies = cookies.OrderBy(c => c).ToArray();

        var ki = 0; // kids index
        for(int i = 0; i < cookies.Length; i++)
        {
            if(ki < kids.Length && cookies[i] >= kids[ki])
            {
                ki++;
            }
        }

        return ki;
    }
}