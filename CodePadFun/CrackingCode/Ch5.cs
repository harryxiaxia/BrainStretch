//5.1 You are given two 32-bit numbers, N and M, and two bit positions, i and j. 
//Write a method to set all bits between i and j in N equal to M 
//(e.g., M becomes a substring of N located at i and starting at j).
public int TwoNumberSubstringInbits(int n1, int n2, int i, int j)
{
    //validate the first set bit in n2;
    //and test this code!
    int mask = ~0;
    mask -= ( 1<<j -1 );
    mask |= ( 1<<i -1 );
    //I like this one!
    return (n1 & mask) | (n2 << i);
}

//5.2 Given a (decimal - e.g. 3.72) number that is passed in as a string, 
//print the binary representation. If the number can not be represented accurately in binary, print “ERROR”
public string decimalToBits(string numStr)
{
    //Todo: validate numStr format
    int intPart = Convert.ToInt32(numStr.SubString(0, numStr.IndexAt('.')));
    int fractionPart = Convert.ToInt32(numStr.SubString(numStr.IndexAt('.')+1));
    
    var intBitString = String.Empty;
    while(intPart > 0)
    {
        int r = intPart % 2;
        intPart >>= 2;
        intBitString = r + intBitString;
    }

    //If it cannot be represent by 32 bits, return error.
    var fractionBitStrBuilder = new StringBuilder();
    while(fractionpart > 0)
    {
        if(fractionBitStrBuilder.Length > 32) return "Error";
        fractionPart *= 2;
        if(fractionPart >= 1)
        {
            fractionBitStrBuilder.Append("1");
            fractionpart -= 1;
        }
        else 
            fractionBitStrBuilder.Append("0");
    }

    return intBitString + "." + fractionBitStrBuilder.ToString();
}
//My practice for int to bit string -- And this is truly wrong
public string IntToBits(int n)
{
    //N is 32 bits
    bool bitFlag = false;
    var stringBuilder = new StringBuilder();
    for(var i=31; i>=0; i++)
    {
        if(n == 0) break;
        if(n - (1<<i) >= 0)
        {
            n -= i<<i;
            stringBuilder.Append('1');
        }
        else if(stringBuilder.Length != 0) 
            stringBuilder.Append('0');   
    }
    if(stringBuilder.Length == 0)
        stringBuilder.Appedn('0');
    
    return stringBuilder.ToString();
}
//Correct and nice one
//Chance is for the ones who are
//preparing for...
public string IntToBitString(int n)
{
    string bitString = string.Empty;
    while(n > 0)
    {
        int r = n % 2;
        n >>= 2;
        bitString = r + bitString;
    }
    return bitString;
}

//5.3 Given an integer, print the next smallest and 
//next largest number that have the same number of 1 bits in their binary representation.
//Try to look at all the problems about find next number with the same 1 bits
//Refer to Leetcode 556. Next Greater Element III
public int[] GetSameBitsNumberMixAndMax(int n)
{
    int count1s = 0;
    int max = 0;
    int min = 0;
    while(n > 0)
    {        
        if(n % 2 == 1) count1s++;
        n >>= 2;
    }

    for(int i=count1s; i>0; i--)
        min = (min << i) + 1;
    
    max = min << (32-count1s);
}
//I think this solution is making no sense and like bullshit!
public bool GetBit(int n, int index)
{
    return (n & (1<<index)) > 0;
}

public int SetBit(int n, int index, bool bit)
{
    if(bool)
        return n | (1 << index);
    else
        return n & (~ (1 << index));
}

//5.4 Explain what the following code does: ((n & (n-1)) == 0).
Check if the least signfication bit is set or not.
It's power of 2;
//5.5 Write a function to determine the number of bits required to convert integer A to integer B.
public int ConvertedBitsCount(int n1, int n2)
{
    int count1s = 0;
    int n = n1^n2;
    while(n > 0)
    {        
        if(n % 2 > 0)
            count1s++;
        n >>= 1;
    }
    return count1s;
}
//Nice one ->
public static int bitSwapRequired(int a, int b)
{
    int count1s = 0;
    for(int i = a^b; i>0; i>>=1)
        count1s += i&1;
    return count1s;
}

//5.7 An array A[1... n] contains all the integers from 0 to n except for one number which is missing.
//Another don't get it question!
public int FindMissingNumber(int[] arr)
{
    
}
public bool GetBitFromIndex(int[] arr, int index, int j){}