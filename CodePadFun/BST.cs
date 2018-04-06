public class BST
{
    class Node
    {
        public K Key { get; set; }
        public V Value { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }
        public int Size { get; set; }
    }

    private Node _root;

    public K Floor(K key)
    {
        if(key == null) throw new InvalidArgumentException("key cannot be null.");
        if(isEmpty()) throw new NoSuchElementException("BST is empty.");

        var floor = Floor(_root, key);
        if(floor == null)
            return null;

        return floor.Key;
    }

    private Node Floor(Node node, K key)
    {
        if(node == null)
            return null;
        int cmp = key.CompareTo(node.Key);
        if(cmp == 0)
            return node;
        if(cmp < 0) Floor(node.Left, key);
        var x = Floor(node.Right, key);
        if(x != null)
            return x;
        return node;
    }

    public K Floor2(K key)
    {
        if(key == null) throw new InvalidArgumentException("key cannot be null.");
        if(isEmpty()) throw new NoSuchElementException("BST is empty.");

        return Floor2(_root, key, null);
    }

    private K Floor2(Node node, K key, k best)
    {
        if(node == null) return best;

        int cmp = key.CompareTo(node.Key);
        if(cmp < 0) return Floor2(node.Left, key, best);
        else if(cmp > 0) return Floor2(node.Right, key, node.Value);
        else if(cmp == 0) return node.Value;
    }

    public K Ceiling(V value)
    {}

    public bool IsEmpty()
    {
        return _root == null;
    }

    public int Size()

    public int Height()
    {
        Height(_root);
    }

    private int Height(Node node)
    {
        if(node == null) return -1;

        return 1 + Math.Max(Height(node.Left), Height(node.Right));
    }

    private Key Select(int index)
    {
        if(index < 0) throw new InvalidArgumentException("Index must be greater than 0");
        
        Node x = Select(_root, index);

        if(x == null)
            return null;
        else 
            return node.Key;
    }

    private node Select(Node node, int index)
    {
        if(node == null) return null;

        int cmp = index.CompareTo(node.Size);
        if(cmp < 0) return Select(node.Left, index);
        else if(cmp > 0) return Select(node.Right, index-node.Size);
        else return node;
    }

    public int Rank(K key){}
    
}