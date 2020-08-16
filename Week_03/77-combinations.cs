public class Solution {
    private List<IList<int>> _results = new List<IList<int>>();
    private int _num;
    private int _amount;
    public IList<IList<int>> Combine(int n, int k) 
    {
        _num = n;
        _amount = k;

        DFS(new List<int>(), 1);

        return _results;    
    }

    private void DFS(IList<int> sub, int begin) // sub[pre1,pre2...prex, begin, ....]
    {           
        if(sub.Count == _amount)
        {
            _results.Add(sub);
            return;
        }

        for(int i = begin; i <= _num; i++)
        {
            var temp = sub.ToList();
            temp.Add(i);
          //  if(i == _num) Console.WriteLine(i+1);
            DFS(temp, i+1);            
        }

    }
}