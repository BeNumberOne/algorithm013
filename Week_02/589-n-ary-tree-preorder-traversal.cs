/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> children;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val,IList<Node> _children) {
        val = _val;
        children = _children;
    }
}
*/

/* Solution 1 Recursion
public class Solution {
    private List<int> _results = new List<int>();
    public IList<int> Preorder(Node root) 
    {
        if(root == null) return _results;

        Recursive(root);
        return _results;
    }

    private void Recursive(Node root)
    {
        _results.Add(root.val);
        foreach(var node in root.children)
        {
            Recursive(node);
        }        
    }
}
*/

//Solution 2 Iteration
public class Solution {
    
    public IList<int> Preorder(Node root) 
    {
        var stack = new Stack<Node>();    
        var results = new List<int>();  

        stack.Push(root);
        while(stack.Count != 0)
        {          
            //Pop
            var node = stack.Pop();
            if(node != null) 
            {                
                Console.WriteLine(node.val);
                results.Add(node.val); // print

                //Push: Push current node's children
                if(node.children != null)
                {
                    for(int i= node.children.Count-1; i >= 0; i--)
                    {
                        stack.Push(node.children[i]);
                    }
                }           
            }            
        }

        return results;
    }
}


















