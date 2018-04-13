//Write code to remove duplicates from an unsorted linked list. FOLLOW UP
//How would you solve this problem if a temporary buffer is not allowed?

//Detect loop in a linked list
class Node<T>
{
    public T Value { get; set; }
    public Node<T> Next { get; set; }
}

public bool HasLoop(Node node)
{
    if(head == null) throw new InvalidArgumentException("List is empty");
    var hashSet = new HashSet<Node>();
    hashSet.Add(node);
    while(node.Next != null)
    {
        node = node.next;
        if(!hashSet.Add(node.value)) return true;
    }
    return false;
}

//I don get this one at all
//Given a circular linked list, implement an algorithm which returns node at the beginning of the loop.
//DEFINITION Circular linked list: A (corrupt) linked list in which a node’s next pointer points to an earlier node, 
//so as to make a loop in the linked list. EXAMPLE
//input: A -> B -> C -> D -> E -> C [the same C as earlier]
//output: C