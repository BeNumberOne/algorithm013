## Note

### Binary Heap
Properties:
* The find max(Min)  O(1)
* Any node's value is always bigger than its left branch and right branch.
* In case the root node's array index is 0,  current node's index is i:
	* Left child index = 2i+1
	* Right child index = 2i+2
	* Father node index = floor((i-1)/2)

### Stack in C#

1. For method **Pop()** and **Peek()** , Stack.Count should be checked before invoking these two methods. 
Otherwise, InvalidOperationException will be thrown in case Count is zero. 
https://docs.microsoft.com/en-us/dotnet/api/system.collections.stack.peek?view=netcore-3.1

**Bad example** in LeetCode coding practice:

```C#
public class Solution {
    public bool IsValid(string s) 
    {    
        if(s==null) return false;

        var stack = new Stack<char>();
        for(int i = 0; i < s.Length; i++)
        {
            if(s[i] == '(') stack.Push(')');
            if(s[i] == '[') stack.Push(']');
            if(s[i] == '{') stack.Push('}');
            if(s[i] == ')' || s[i] == ']'|| s[i] == '}')
            {
                if(s[i] != stack.Peek()) // Exception will be thrown here in some cases
                {
                    return false;
                }
                stack.Pop();                
            }
        }
        return stack.Count == 0;
    }
}
```



## LeetCode Daily

### 239 sliding-window-maximum **Hard**
#### Best Soultion: Deque
#### Note: 
1. It can been seen as an advanced maintaining **Monotonous Stack** problem. **Monotonous Stack** is widely used to search the next greater element, **NGE**.
2. Deque is used to log the index **NOT** value. All the indexes in deque are naturally ordered. 
3. In Deque: Head <- left num's index <- ...<- right num's index <- Tail. And the head ones are always bigger.
4. a If the index in Deque is out of window's range, remove. 
4. b If the index in Deque is smaller than the current, remove.
5. As each index is added to deque only once, the adding complexity is O(n). In step 4, the deleting only happens once for each value. So the Deleting complexity is O(n). The total time complexity is O(n).

#### Related LC problems:
907. Sum of Subarray Minimums
739. Daily Temperatures
503. Next Greater Element II
641. design circular deque
