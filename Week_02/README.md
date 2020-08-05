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
