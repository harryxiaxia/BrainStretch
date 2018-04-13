//Implement a function to check if a binary 
//tree is balanced. For the purposes of this question, 
//a balanced tree is defined to be a tree 
//such that no two leaf nodes differ in distance from the root by more than one.
public bool IsBinaryTreeBalanced(Node root)
{
    if(root == null) throw new InvalidArgumentException("Root it null.");
    return Math.Abs(Height(root.Left), Heigth(root.Right)) <= 1 && IsBinaryTreeBalanced(root.Left) && IsBinaryTreeBalanced(root.Right);
}

public int Height(Node node)
{
    if(node == null) return -1;
    return Math.Max(Height(Node.Left), Height(Node.Right)) + 1;
}

//4.2 Given a directed graph, design an algorithm to find out whether there is a route between two nodes.
//Connectivity problem
public class Connectivity
{
    private bool[] marked;
    private int[] Connected;
    private count = 0;
    public Connectivity(DGraph g)
    {
        foreach(var i in g.V())
            if(!marked[i]) 
            {
                Dfs(g, i);
                count++;
            }                
    }

    private void Dfs(DGraph g, int i)
    {
        marked[i] = true;
        Connected[i] = count;
        foreach(var v in g.Adj(i))
            if(!marked[v])
                Dfs(g, v);
    }

    public bool IsConnected(int i, int j)
    {
        //Todo: validate i and j
        return Connected[i] == Connected[j];
    }
}