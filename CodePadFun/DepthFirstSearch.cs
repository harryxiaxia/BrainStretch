public Graph
{
    public int V()
    public int E()
    public void AddEdge(int v, int w)
    IEnumerable<int> Adj(int v)
}

public class Search
{
    private bool[] _marked;
    private int _count;
    public Search(Graph G, int s)
    {
        _marked = new bool[G.V()];
        Dfs(g, s);
    }    

    public bool Marked(int v)
    {
        return _marked[v];
    }

    private void Dfs(Graph g, int s)
    {
        _count++;
        _marked[s] = true;
        foreach(var v in g.Adj())
            if(!_marked[v])
                Dfs(graph, v);
    }

    public bool Count()
    {
        return _count;
    }

    private void ValidateVertex(int v)
    {
        int len = _marked.Length();
        if(v<0 || v>=len)
            throw new InvalidArgumentException($"Vertex {v} is not exist in graph");
    }
}

public class Paths
{
    private bool[] _marked;
    private int[] _pathTo;
    private int _source;

    public Paths(Graph g, int s)
    {
        ValidateVertex
        _marked = new bool[g.V()];
        _source = s;
        Dfs(g, s);
    }

    public bool HasPathTo(int v)
    {
        return _marked[v];
    }

    private void Dfs(Graph g, int s)
    {
        _marked[s] = true;
        foreach(var i in g.Adj())
            if(!_marked[s])
            {
                _pathTo[i] = s; 
                Dfs(g, s);
            }                
    }

    public IEnumerable<int> Path(int v)
    {
        var stack = new Stack<int>();
        stack.Add(_source);
        if(!_marked[v])
            return null;
        for(int x=v; x != _source, x = _pathTo[v])
            stack.Add(v);
        
        return stack;
    }

    private void ValidateVertex(int v)
    {
        int len = _marked.Length();
        if(v<0 || v>=len)
            throw new InvalidArgumentException($"Vertex {v} is not exist in graph");
    }
}