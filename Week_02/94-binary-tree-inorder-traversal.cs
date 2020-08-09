/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    public IList<int> InorderTraversal(TreeNode root) 
    {
        var results = new List<int>();
        if(root == null) return results;

        var stack = new Stack<TreeNode>();     
        var current = root;

        (stack.Count != 0 || current != null)
        {
            if(current != null)
            {
                Console.WriteLine(current.val);
                stack.Push(current);
                current = current.left;
            }
            else
            {
                var fatherNode = stack.Pop();
                current = fatherNode.right;

                results.Add(fatherNode.val);
            }
        }

        return results;
    }
}