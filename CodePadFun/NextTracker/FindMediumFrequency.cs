public class CodeFun
{
    public MediumFrequency FindMediumFrequency(List<T> list) where T : IEquable<T>
    {
        var dic = new Dictionary<T, int>();
        foreach(var i in list)
        {
            if(dic.Keys.contain(i))
                dic[i]++;
            else
                dic.Add({i, 1});
        }

        var listValue = dic.Value().OrderBy(r => r).ToList();
        var mediumValue = listValue[listValue.Length / 2];
        
        foreach(var k in dic.Keys())
        {
            if(dic[k] == mediumValue)
                return new FindMediumFrequency{T = k, Count = dic[k]};
        }
    }

    class MediumFrequency<T>
    {
        public T Value { get; set; }
        public int Count { get; set; }
    }
}
