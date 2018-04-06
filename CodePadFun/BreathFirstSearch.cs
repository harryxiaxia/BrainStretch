public class BreathFirstSearch
{
    private Graph _graph;
    private bool[] _marked;
    private int[] _pathTo;
    private int _source;
    public BreathFirstSearch(Graph g, int s)
    {
        ValidateVertex(s);
        _source = s;
        _marked = new bool[g.V()];
        Bfs(graph, s);
    }

    private void Bfs(Graph g, int s)
    {
        var queue = new Queue<int>();
        _marked[s] = true;
        queue.Enqueue(s);

        while(!_queue.IsEmpty())
        {
            var x = _queue.DeQueue();
            foreach(var v in g.Adj(x))
                if(!_marked[v])
                {
                    _pathTo[v] = x;
                    _marked[x] = true;
                    _queue.EnQueue(v);
                }
        }
    }

    public bool HasPathTo(int v)
    {
        return _marked[v];
    }

    public IEnumerable<int> PathTo(int v)
    {
        var stack = new Stack<int> stack;
        stack.Add(v);
        if(!_marked[v])
            return null;
        
        for(int x=_pathTo[v], x!=_source, x=_pathTo[x])
            stack.Add(x);
        
        return stack;
    }

    private void ValidateVertex(int s){}
}