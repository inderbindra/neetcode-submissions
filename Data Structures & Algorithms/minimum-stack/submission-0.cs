public class MinStack {

    Stack<(int val, int minVal)> stack;
    int minVal;
    public MinStack() {
        stack = new();
        minVal = int.MaxValue;
    }
    
    public void Push(int val) {
        if(minVal > val)
        {
            minVal = val;
        }
        stack.Push((val, minVal));
    }
    
    public void Pop() {
        stack.Pop();
        minVal = stack.Count > 0 ? stack.Peek().minVal : int.MaxValue;
    }
    
    public int Top() {
        return stack.Peek().val;
    }
    
    public int GetMin() {
        return stack.Peek().minVal;
    }
}
