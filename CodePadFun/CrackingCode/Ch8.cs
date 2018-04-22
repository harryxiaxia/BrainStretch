public int FibonacciNth(int n)
{
    //Todo, validate n, should be greater than 0;
    if(n = 0)
        return 0;
    else if(n = 1)
        return 1;
    else
        return f(n) + f(n-1);
}

public int FibonacciNth_Iterative_array(int n)
{
    //Todo, validate n, should be greater than 0;
    var arr = new int[n];
    for(int i=0; i<arr.Length; i++)
    {
        if(i==0) arr[i] = 0;
        else if(i == 1) arr[i] = 1;
        else arr[i] = arr[i-1] + arr[i-2];
    }
    return arr[n-1];
}

public int FibonacciNth_Iterative(int n)
{
    //Todo, validate n, should be greater than 0;
    if(n == 0) return 0;
    else if(n = 1) return 1;
    else
    {
        int a = 0, b = 1;
        for(int i=2; i<n; i++)
        {
            int c = a + b;
            a = b;
            b = c;
        }
        return b;
    }
}

public int Gcd(int a, int b)
{
    if(b == 0) return a;
    
    else Gcd(b, a % b);
}