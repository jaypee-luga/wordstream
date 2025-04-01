using System;

namespace wordCounter;

public static class stringExtensions
{
    public static int wordCount(this string str)
    {
        return str.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;
    }

    public static List<string> fiveLargestWords(this string str)
    {
        var dictionary = new Dictionary<string, int>();
        foreach (var s in str.Split(' ', StringSplitOptions.RemoveEmptyEntries))
        {
            if (!dictionary.ContainsKey(s))
                dictionary.Add(s, s.Length);
        }
        //dictionary.Take
        return default;
    }

    public static List<string> fiveSmallestWords(this string str)
    {
        return default;
    }

    public static List<string> top10frequentlyAppearingWords(this string str)
    {
        return default(List<string>);

    }

    public static Dictionary<char, int> allCharacters(this string str)
    {
        return default(Dictionary<char, int>);
    }
    //statci
}
