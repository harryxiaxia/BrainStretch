//19.1 Write a function to swap a number in place without temporary variables.
//No temp variable
//a = a^b -> b = a^b; a = b^a;
public void Swap(int[] arr, int i, int j)
{
    arr[i] = arr[i]^arr[j];
    arr[j] = arr[i]^arr[j];
    arr[i] = arr[i]^arr[j];
}

//19.2 Design an algorithm to figure out if someone has won in a game of tic-tac-toe.
//T T F
//F T F
//F F F
public int WhoWins(int[][] board)
{
    //6 paths to check
    foreach(var i=0; i<3; i++)
    {
        //rows
        foreach(var j=0; j<3; j++)
    }
}

//19.7 You are given an array of integers (both positive and negative).
//Find the continuous sequence with the largest sum. Return the sum.
public int FindLargestSum(int[] arr)
{
    int max = 0;
    int sum = 0;
    for(int i=0; i<arr.Length; i++)
    {
        sum += arr[i];
        if(max < sum)
            max = sum;
        if(sum < 0)
            sum = 0;
    }
    return max;
}

public int Mul(int x, int y)
{
    int result;
    for(var i=0; i<y; i++)
        result = Add(result, x);
    return result;
}

public int Div(int x, int y)
{
    if(y == 0) throw new Exception();
    int result;
    while(x > 0)
    {
        x = Add(x, -y);
        if(x >= 0) result++;
    }
    return result;
}
public int Add(int x, int y)
{
    while(y != 0)
    {
        int carry = x & y;
        x ^= y;
        y = carry << 1;
    }
    return x;
}