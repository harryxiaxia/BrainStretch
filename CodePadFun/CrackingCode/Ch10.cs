//Example: Given two numbers m and n, 
//write a method to return the first number r that is divisible by both 
//(e.g., the least common multiple).
//They are really math problems!!!
//10.1 You have a basketball hoop and someone says that you can play 1 of 2 games.
//It's an all right problem

//10.2 Similarly find the probability of collision with ‘n’ ants on an ‘n’ vertex polygon.
1 - 1/4
1 - 1/2^(n-1)

//10.3 Given two lines on a Cartesian plane, determine whether the two lines would intersect.
//Cartesian plane

//10.4 Write a method to implement *, - , / operations. You should use only the + operator.
public int Plus(int a, int b){}

public int Mul(int a, int b)
{
    int times = b;
    int result = 0;
    while(times >= 0)
    {
        result += Plus(a, a);
        times--;
    }
    return result;
}

public int Minus(int a, int b)
{
    return Plus(a, -b);
}

public int Div(int a, int b)
{
    int c = a;
    int count = 0
    while(Minus(c, b) > 0)
    {
        c = Minus(c, b);
        count++;
    }
    return count;    
}

//10.5 Given two squares on a two dimensional plane, find a line that would cut these two squares in half.

//10.6 10.6 Given a two dimensional graph with points on it, find a line which passes the most number of points.
//Maybe go back later!!!

//10.7 Design an algorithm to find the kth number such that the only prime factors are 3, 5, and 7.
//Yeah, Maybe later!