using System;

// To execute C#, please define "static void Main" on a class
// named Solution.
/*
You’re given an array of CSV strings representing search results. Results are sorted by a score initially. A given host may have several listings that show up in these results. Suppose we want to show 12 results per page, but we don’t want the same host to dominate the results. Write a function that will reorder the list so that a host shows up at most once on a page if possible, but otherwise preserves the ordering. Your program should return the new array and print out the results in blocks representing the pages.

[
    "host_id,listing_id,score,city",
    "1,28,300.1,San Francisco",
    "4,5,209.1,San Francisco",
    "20,7,208.1,San Francisco",
    "23,8,207.1,San Francisco",
    "16,10,206.1,Oakland",
    "1,16,205.1,San Francisco",
    "1,31,204.6,San Francisco",
    "6,29,204.1,San Francisco",
    "7,20,203.1,San Francisco",
    "8,21,202.1,San Francisco",
    "2,18,201.1,San Francisco",
    "2,30,200.1,San Francisco",
    "15,27,109.1,Oakland",
    "10,13,108.1,Oakland",
    "11,26,107.1,Oakland",
    "12,9,106.1,Oakland",
    "13,1,105.1,Oakland",
    "22,17,104.1,Oakland",
    "1,2,103.1,Oakland",
    "28,24,102.1,Oakland",
    "18,14,11.1,San Jose",
    "6,25,10.1,Oakland",
    "19,15,9.1,San Jose",
    "3,19,8.1,San Jose",
    "3,11,7.1,Oakland",
    "27,12,6.1,Oakland",
    "1,3,5.1,Oakland",
    "25,4,4.1,San Jose",
    "5,6,3.1,San Jose",
    "29,22,2.1,San Jose",
    "30,23,1.1,San Jose"
]
*/

class Solution
{
    class CityScore
    {
        //host_id,listing_id,score,city
        public int HostId {get; set;}
        public int ListingId{get; set;}
        public double Score{get; set;}
        public string City{get; set;}
    }
    public List<String> getInput() {
        List<String> input = new List<String>();
        input.Add("host_id,listing_id,score,city");
        input.Add("1,28,300.1,San Francisco");
        input.Add("4,5,209.1,San Francisco");
        input.Add("20,7,208.1,San Francisco");
        input.Add("23,8,207.1,San Francisco");
        input.Add("16,10,206.1,Oakland");
        input.Add("1,16,205.1,San Francisco");
        input.Add("1,31,204.6,San Francisco");
        input.Add("6,29,204.1,San Francisco");
        input.Add("7,20,203.1,San Francisco");
        input.Add("8,21,202.1,San Francisco");
        input.Add("2,18,201.1,San Francisco");
        input.Add("2,30,200.1,San Francisco");
        input.Add("15,27,109.1,Oakland");
        input.Add("10,13,108.1,Oakland");
        input.Add("11,26,107.1,Oakland");
        input.Add("12,9,106.1,Oakland");
        input.Add("13,1,105.1,Oakland");
        input.Add("22,17,104.1,Oakland");
        input.Add("1,2,103.1,Oakland");
        input.Add("28,24,102.1,Oakland");
        input.Add("18,14,11.1,San Jose");
        input.Add("6,25,10.1,Oakland");
        input.Add("19,15,9.1,San Jose");
        input.Add("3,19,8.1,San Jose");
        input.Add("3,11,7.1,Oakland");
        input.Add("27,12,6.1,Oakland");
        input.Add("1,3,5.1,Oakland");
        input.Add("25,4,4.1,San Jose");
        input.Add("5,6,3.1,San Jose");
        input.Add("29,22,2.1,San Jose");
        input.Add("30,23,1.1,San Jose");
        return input;
    }
    
    public List<List<CityScore>> GetArrangedCityScoreResult(List<CityScore> list)
    {        
        HashSet<int> hostIdSet = new HashSet<int>();
        Queue<CityScore> buffer = new Queue<CityScore>();
        Queue<CityScore> temBuffer = new Queue<CityScore>();
        List<List<CityScore>> result = new List<List<CityScore>>();
        int index = 0;
        for(int i=0; i<list.Lenght; i++)
        {
            if(result[index].Length == 12)
            {
                index++;
                hostIdSet.Clear();
            }
            
            //Queue<CityScore> temBuffer = new Queue<CityScore>();
            while(!buffer.IsEmpty())
            {
                var cityScore = buffer.DeQueue();
                if(hostIdSet.Add(cityScore.HostId))
                    result[index].Add(cityScore);
                else
                    temBuffer.Enqueue(cityScore);
            }
            buffer = temBuffer;
            temBuffer.Clear();
                
            var item = list[i];
            
            if(hostIdSet.Add(item.HostId))
                result[index].Add(item);
            else
                buffer.Add(item);
        }
        
        return result;
    }
    
    public void PrintArrangedCityScoreResult(List<CityScore> list)
    {
        var list = GetArrangedCityScoreResult(list);
        //foreach(var l in list)
        //Todo: print the list of list
    }
}


using System;

// To execute C#, please define "static void Main" on a class
// named Solution.
/*
You’re given an array of CSV strings representing search results. Results are sorted by a score initially. A given host may have several listings that show up in these results. Suppose we want to show 12 results per page, but we don’t want the same host to dominate the results. Write a function that will reorder the list so that a host shows up at most once on a page if possible, but otherwise preserves the ordering. Your program should return the new array and print out the results in blocks representing the pages.

[
    "host_id,listing_id,score,city",
    "1,28,300.1,San Francisco",
    "4,5,209.1,San Francisco",
    "20,7,208.1,San Francisco",
    "23,8,207.1,San Francisco",
    "16,10,206.1,Oakland",
    "1,16,205.1,San Francisco",
    "1,31,204.6,San Francisco",
    "6,29,204.1,San Francisco",
    "7,20,203.1,San Francisco",
    "8,21,202.1,San Francisco",
    "2,18,201.1,San Francisco",
    "2,30,200.1,San Francisco",
    "15,27,109.1,Oakland",
    "10,13,108.1,Oakland",
    "11,26,107.1,Oakland",
    "12,9,106.1,Oakland",
    "13,1,105.1,Oakland",
    "22,17,104.1,Oakland",
    "1,2,103.1,Oakland",
    "28,24,102.1,Oakland",
    "18,14,11.1,San Jose",
    "6,25,10.1,Oakland",
    "19,15,9.1,San Jose",
    "3,19,8.1,San Jose",
    "3,11,7.1,Oakland",
    "27,12,6.1,Oakland",
    "1,3,5.1,Oakland",
    "25,4,4.1,San Jose",
    "5,6,3.1,San Jose",
    "29,22,2.1,San Jose",
    "30,23,1.1,San Jose"
]
*/

class Solution
{
    class CityScore
    {
        //host_id,listing_id,score,city
        public int HostId {get; set;}
        public int ListingId{get; set;}
        public double Score{get; set;}
        public string City{get; set;}
    }
    public List<String> getInput() {
        List<String> input = new List<String>();
        input.Add("host_id,listing_id,score,city");
        input.Add("1,28,300.1,San Francisco");
        input.Add("4,5,209.1,San Francisco");
        input.Add("20,7,208.1,San Francisco");
        input.Add("23,8,207.1,San Francisco");
        input.Add("16,10,206.1,Oakland");
        input.Add("1,16,205.1,San Francisco");
        input.Add("1,31,204.6,San Francisco");
        input.Add("6,29,204.1,San Francisco");
        input.Add("7,20,203.1,San Francisco");
        input.Add("8,21,202.1,San Francisco");
        input.Add("2,18,201.1,San Francisco");
        input.Add("2,30,200.1,San Francisco");
        input.Add("15,27,109.1,Oakland");
        input.Add("10,13,108.1,Oakland");
        input.Add("11,26,107.1,Oakland");
        input.Add("12,9,106.1,Oakland");
        input.Add("13,1,105.1,Oakland");
        input.Add("22,17,104.1,Oakland");
        input.Add("1,2,103.1,Oakland");
        input.Add("28,24,102.1,Oakland");
        input.Add("18,14,11.1,San Jose");
        input.Add("6,25,10.1,Oakland");
        input.Add("19,15,9.1,San Jose");
        input.Add("3,19,8.1,San Jose");
        input.Add("3,11,7.1,Oakland");
        input.Add("27,12,6.1,Oakland");
        input.Add("1,3,5.1,Oakland");
        input.Add("25,4,4.1,San Jose");
        input.Add("5,6,3.1,San Jose");
        input.Add("29,22,2.1,San Jose");
        input.Add("30,23,1.1,San Jose");
        return input;
    }
    
    public List<List<CityScore>> GetArrangedCityScoreResult(List<CityScore> list)
    {        
        HashSet<int> hostIdSet = new HashSet<int>();
        Queue<CityScore> buffer = new Queue<CityScore>();
        Queue<CityScore> temBuffer = new Queue<CityScore>();
        List<List<CityScore>> result = new List<List<CityScore>>();
        int index = 0;
        for(int i=0; i<list.Lenght; i++)
        {
            if(result[index].Length == 12)
            {
                index++;
                hostIdSet.Clear();
                if(tempBuffer != null)
                {
                    buffer = temBuffer;
                    temBuffer.Clear();
                }
            }
            
            //Queue<CityScore> temBuffer = new Queue<CityScore>();
            while(temBuffer.IsEmpty() && !buffer.IsEmpty())
            {
                var cityScore = buffer.DeQueue();
                if(hostIdSet.Add(cityScore.HostId))
                    result[index].Add(cityScore);
                else
                    temBuffer.Enqueue(cityScore);
            }
                
            var item = list[i];
            
            if(hostIdSet.Add(item.HostId))
                result[index].Add(item);
            else
                buffer.Add(item);
        }
        
        return result;
    }
    
    public void PrintArrangedCityScoreResult(List<CityScore> list)
    {
        var list = GetArrangedCityScoreResult(list);
        //foreach(var l in list)
        //Todo: print the list of list
    }
}
