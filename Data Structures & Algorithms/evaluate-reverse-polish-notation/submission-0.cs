public class Solution {
    public int EvalRPN(string[] tokens) {
        Dictionary<string, Func<int, int, int>> operatorMap = new()
        {
            {"+", (n1, n2)=> {return n1+n2;}},
            {"-", (n1, n2)=> {return n2-n1;}},
            {"*", (n1, n2)=> {return n1*n2;}},
            {"/", (n1, n2)=> {return n2/n1;}},
        };

        Stack<int> stack = new();
        int n1, n2, num;
        for(int i=0; i<tokens.Length; i++)
        {
            if(operatorMap.ContainsKey(tokens[i]))
            {
                n1 = stack.Pop();
                n2 = stack.Pop();
                num = operatorMap[tokens[i]](n1, n2);
            }
            else
            {
                num = Convert.ToInt32(tokens[i]);
            }
            stack.Push(num);
        }
        return stack.Peek();
    }
}
