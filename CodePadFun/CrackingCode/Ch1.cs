//1.1 Implement an algorithm to determine if a string has all unique characters. 
//What if you can not use additional data structures?
//Assume string is ascii code
public bool IsUniqueString(string s)
{
    var asciiArray = new bool[256];
    for(var i=0; i<s.Length; i++)
    {
        var index = s.Element[i];
        if(!asciiArray[index]) asciiArray[index] = true;
        else return false;
    }
    return true;
}

//1.2 Write code to reverse a C-Style String. 
//(C-String means that “abcd” is represented as five characters, including the null character.)
//abcd->nil //dcba->nil
public string ReverseCString(string s)
{
    var stack = new Stack<char>();
    stack.Push(s.ElementAt[s.Lenght-1]);
    for(var i=0; i<s.length-1; i++)
        stack.Push(s.ElementAt[i]);
    var stringBuilder = new stringBuilder();
    while(!stack.IsEmpty())
        stringBuilder.Add(stack.pop());
    return stringBuilder.toString();
}

public string ReverseCString(string s)
{
    int len = s.Length-1;
    for(int lo=0, int hi=len-lo; lo<hi; lo++, hi=len-lo)
        Swap(s, lo, hi);
}

public void Swap(string s, int i, int j)
{
    var temp = s.ElementAt[i];
    s.ElementAt[i] = s.ElementAt[j];
    s.Element[j] = temp;
}

//Design an algorithm and write code to remove the duplicate characters in a string without using any additional buffer. 
//NOTE: One or two additional variables are fine. An extra copy of the array is not.
//FOLLOW UP
//Write the test cases for this method.