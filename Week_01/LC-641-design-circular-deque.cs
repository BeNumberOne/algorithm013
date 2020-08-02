public class MyCircularDeque 
{
    int _size;
    int _k;
    private DoubleLinkNode _head;
    private DoubleLinkNode _tail;

    /** Initialize your data structure here. Set the size of the deque to be k. */
    public MyCircularDeque(int k)
    {
        _head = new DoubleLinkNode(-1);
        _tail = new DoubleLinkNode(-1);
        _head.next = _tail;
        _tail.pre = _head;

        _size = 0;
        _k = k;
    }

    /** Adds an item at the front of Deque. Return true if the operation is successful. */
    public bool InsertFront(int value)
    {
        if (_size == _k) return false;

        var node = new DoubleLinkNode(value)
                        {
                            pre = _head,
                            next = _head.next
                        };
        
        _head.next.pre = node;
        _head.next = node;

        _size++;

        return true;

    }

    /** Adds an item at the rear of Deque. Return true if the operation is successful. */
    public bool InsertLast(int value)
    {
        if (_size == _k) return false;

        var node = new DoubleLinkNode(value) { next = _tail, pre = _tail.pre };
        _tail.pre.next = node;
        _tail.pre = node;

        _size++;

        return true;
    }

    /** Deletes an item from the front of Deque. Return true if the operation is successful. */
    public bool DeleteFront()
    {
        if (_size == 0) return false;
        _head.next.next.pre = _head;
        _head.next = _head.next.next;

        _size--;

        return true;
    }

    /** Deletes an item from the rear of Deque. Return true if the operation is successful. */
    public bool DeleteLast()
    {
        if (_size == 0) return false;

        _tail.pre.pre.next = _tail;
        _tail.pre = _tail.pre.pre;

        _size--;
        return true;
    }

    /** Get the front item from the deque. */
    public int GetFront()
    {
        return _head.next.value;
    }

    /** Get the last item from the deque. */
    public int GetRear()
    {
        return _tail.pre.value;
    }

    /** Checks whether the circular deque is empty or not. */
    public bool IsEmpty()
    {
        return _size == 0;
    }

    /** Checks whether the circular deque is full or not. */
    public bool IsFull()
    {
        return _size == _k;
    }
}

public class DoubleLinkNode
{
    public DoubleLinkNode pre { get; set; }
    public DoubleLinkNode next { get; set; }

    public int value { get; set; }

    public DoubleLinkNode(int val)
    {
        value = val;
    }
}
/**
 * Your MyCircularDeque object will be instantiated and called as such:
 * MyCircularDeque obj = new MyCircularDeque(k);
 * bool param_1 = obj.InsertFront(value);
 * bool param_2 = obj.InsertLast(value);
 * bool param_3 = obj.DeleteFront();
 * bool param_4 = obj.DeleteLast();
 * int param_5 = obj.GetFront();
 * int param_6 = obj.GetRear();
 * bool param_7 = obj.IsEmpty();
 * bool param_8 = obj.IsFull();
 */