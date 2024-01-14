public class MyQueue {
    private readonly Stack primaryStack;
    private readonly Stack holdingStack; 

    public MyQueue() {
        primaryStack = new Stack();
        holdingStack = new Stack();
    }
    
    public void Push(int x) {
        while(primaryStack.Count > 0) holdingStack.Push(primaryStack.Pop());
        holdingStack.Push(x);

        while(holdingStack.Count > 0) primaryStack.Push(holdingStack.Pop());
    }
    
    public int Pop() {
        return (int)primaryStack.Pop();
    }
    
    public int Peek() {
        return (int)primaryStack.Peek();
    }
    
    public bool Empty() {
        return primaryStack.Count == 0;
    }
}

/**
 * Your MyQueue object will be instantiated and called as such:
 * MyQueue obj = new MyQueue();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Peek();
 * bool param_4 = obj.Empty();
 */