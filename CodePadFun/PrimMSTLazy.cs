public class PrimMSTLazy 
{
    private Queue<Edge> _mstQueue;
    private MinPQ<Edge> _minPQ;
    private bool[] _marked;

    public PrimMSTLazy(EdgeWeightedGraph g, int v)
    {
        _mstQueue = new Queue<Edge>();
        _minPQ = new MinPQ<Edge>();
        _marked = new bool[g.V()];
        Scan(g, v);
        while (_mstQueue < (g.V() -1))
        {
            var e = _minPQ.DelMin();
            var v1 = e.Either;
            var v2 = e.TheOther(v2);
            if(_marked[v1] && _marked[v2]) continue;
            _mstQueue.Enqueue(e);
            if(_marked[v1] == false) Scan(g, v1);
            if(_marked[v2] == false) Scan(g, v2};
        }
    }

    private void Scan(EdgeWeightedGraph g, int v)
    {
        _marked[v] = true;
        foreach(var x in g.Adj(v))
            if(!_marked[v.TheOther(v)])
                _minPQ.Insert(x);
    }
}

public class Edge
{
    public int Either { get; set; }
    public int Weight { get; set; }
    public int TheOther(int v){}
}