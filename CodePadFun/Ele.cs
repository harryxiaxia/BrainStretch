//***********Ch5*************/

//***********Ch6*************/
public int[] GetSpialSequence(int[][] arr)
{

}

//***********Ch7*************/

//***********Ch8*************/

//***********Ch9*************/

//***********Ch10*************/
public bool IsBalanced(Node<T> root)
{
    if(root == null) throw;
    return Math.Abs(Height(root.Left) - Height(root.Right)) <= 1;
}

public int Height(Node<T> node)
{
    if(node == null) return -1;
    return Math.Max(Height(node.left), Height(node.Right)) + 1;
}

public bool IsSymmetric(Node<T> root)
{
    if(root == null) throw;
    var queue = new Queue<T>();
    queue.Add(root);
    while(!queue.IsEmpty())
    {
        var list = new List<T>();
        while(!queue.IsEmtpy())
        {
            var node = queue.DeQueue();
            if(node.Left != null) list.Add(node.Left);
            if(node.Right != null) list.Add(node.Right);
        }
        if(!IsParlindrome(list)) return false;
        foreach(var n in list) queue.Enqueue(n);
    }
    return true;
}

public bool IsParlindrome(List<T> list)
//***********Ch11*************/

//***********Ch12*************/

//***********Ch13*************/

//***********Ch14*************/

//***********Ch15*************/

//***********Ch16*************/

//***********Ch17*************/

//***********Ch18*************/

//***********Ch19*************/

//***********Ch20*************/

//***********Ch21*************/

//***********Ch22*************/

//***********Ch23*************/

//***********Ch24*************/

//***********Ch25*************/