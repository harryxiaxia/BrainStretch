//You have a very large array of ‘Person’ objects. Sort the people in increasing order of age.
class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}

private List<Person> _allPerson

public List<Person> SortByAge(List<Person> persons)
{
    //Assume person age range from 0 - 120
    var personGroup = new List<List<Person>>();
    var result = new List<Person>();
    foreach(var p in persons)
    {
        if(personGroup[p.Age]  == null)
        {
            personGroup[p.Age] = new List<Person>{p};            
        }
        else
            personGroup[p.Age].Add(p);
    }
    
    foreach(var pGroup in personGroup)
        if(p != null)
            result.AddRange(pGroup);
        
    return result;
}

//9.1 You are given two sorted arrays, A and B, 
//and A has a large enough buffer at the end to hold B. Write a method to merge B into A in sorted order.
public void Merge(int[] a, int[] b, int m)
{
    int i = m - 1;
    int j = b.Length - 1;
    int k = m + b.Length - 1;
    while(i >= 0 && j >= 0)
    {
        if(a[i] > b[j]) {a[k--] = a[i--];}
        else {a[k--] = b[j--];}
    }

    while(j >= 0)
    {
        a[k--] = b[j--]; 
    }
}

//9.2 Write a method to sort an array of strings so that all the anagrams are next to each other.
//I think this is a great example, well, all in all this book is great.
public void Sort(string[] arr)
{
    Array.Sort(arr, StringCompareByAnagrams);
}

public int StringCompareByAnagrams(string s1, string s2)
{
    return SortStringCharacters(s1).CompareTo(SortStringCharacters(s2));
}

private string SortStringCharacters(string s)
{
    char[] arr = s.ToCharArray();
    Array.Sort(arr);
    return new string(c);
}

//Given a sorted array of n integers that has been rotated an unknown number of times, 
//give an O(log n) algorithm that finds an element in the array.
//I think it's a very interesting problem.
//6 7 8 9 10 11 13 14 1 2 3 4 5
//7 8 9 1 2 3 4 5 6 

//It's better to be tested in Leetcode
public int FindElement(int[] arr, int item)
{
    int lo = 0; 
    int hi = arr.Length - 1;
    while(lo <= hi)
    {
        int mid = (lo + hi)/2;
        if(item = arr[mid]) return item;
        else if(arr[lo] <= arr[hi])
        {
            if(item < arr[mid]) hi = mid -1;
            else lo = mid + 1;
        }
        else if(item < arr[mid]) hi = mid - 1;
        else
        {
            if(arr[hi] > item) lo = mid + 1;
            else hi = mid - 1;
        }                
    }
}

//9.6 Given a matrix in which each row and each column is sorted, write a method to find an element in it.
//It's worth to practice in Leetcode

//9.7 Given the heights and weights of each person in the circus, 
//write a method to compute the largest possible number of people in such a tower.
//I don't see value of this problem.


