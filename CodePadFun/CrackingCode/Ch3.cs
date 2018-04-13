//3.1 Describe how you could use a single array to implement three stacks.
//I don't see the point

//3.4 In the classic problem of the Towers of Hanoi, you have 3 rods and N disks of different sizes which can slide onto any tower.
public void Hanoi(int count, Stack<T> from, Stack<T> buffer, Stack<T> to)
{
    //Move all item from from to to.
    if(count == 0)
        to.Push(from.Pop());
    Hanoi(n-1, from, to, buffer);
    to.Push(from.Pop());
    Hanoi(n-1, buffer, from, to);
}

//3.6 Write a program to sort a stack in ascending order. 
//You should not make any assumptions about how the stack is implemented. 
//The following are the only functions that should be used to write this program: push | pop | peek | isEmpty.
public void SortStackAscending(stack<T> s)
{
    var r = new Stack<T>();
    while(!s.IsEmpty())
    {
        var sTop = s.Pop();
        while(!r.IsEmpty() && r.Peek().Compare(sTop) < 0) s.Push(r.Pop());
        r.Push(sTop);
    }
    return r;
}