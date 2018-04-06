public class BreathFirstDGraph
{
    private bool[] _marked;
    private int[] _pathTo;
    private int _source
    private Queue<int> queue;

    public BreathFirstDGraph(Graph g, int s)
    {
        _source = s;        
        _marked = new _marked[g.V()];
        _queue.Enqueue(s);
    }

    private void Bst(Graph g, int s)
    {
        _marked[s] = true;
        while(!_queue.IsEmtpy())
        {
            var v = _queue.Dequeue();
            foreach(var x in g.Adj(v))
                if(!_marked[x])
                { 
                    _marked[x] = true;
                    _pathTo[x] = v;
                    _queue.Enqueue(x);
                }
        }
    }

    public bool HasPathTo(int d)
    {
        return _marked[d];
    }

    public IEnumerable<int> GetPath(int d)
    {
        if(!HasPathTo())
            return Enumerable.Empty();
        var stack = new Stack<int>();
        for(int i = d; i != _source; i = _pathTo[i])
            stack.Push(i);
        stack.Push(_source);
    }
}