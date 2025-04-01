using System;

namespace wordCounter;

public static class stringExtensions
{
    public static int wordCount(this string str)
    {
        return str.Split(new char[] { ' ', '.' }, StringSplitOptions.RemoveEmptyEntries).Length;
    }

    public static List<string> fiveLargestWords(this string str)
    {
        var result = new List<string>();
        var dict = new Dictionary<string, int>();
        foreach (var s in str.ToLower().Split(new char[] { ' ', '.' }, StringSplitOptions.RemoveEmptyEntries))
        {
            if (!dict.ContainsKey(s))
                dict.Add(s, s.Length);
        }

        for (int i = 0; i < 5; i++)
        {
            var keyOfMaxValue = dict.MaxBy(s => s.Value).Key;
            result.Add(keyOfMaxValue.ToString());
            dict.Remove(keyOfMaxValue);
        }

        return result;
    }

    public static List<string> fiveSmallestWords(this string str)
    {
        var result = new List<string>();
        var dict = new Dictionary<string, int>();
        foreach (var s in str.ToLower().Split(new char[] { ' ', '.' }, StringSplitOptions.RemoveEmptyEntries))
        {
            if (!dict.ContainsKey(s))
                dict.Add(s, s.Length);
        }

        for (int i = 0; i < 5; i++)
        {
            var keyOfMinValue = dict.MinBy(s => s.Value).Key;
            result.Add(keyOfMinValue.ToString());
            dict.Remove(keyOfMinValue);
        }

        return result;
    }

    public static List<string> top10frequentlyAppearingWords(this string str)
    {
        var result = new List<string>();
        var dict = new Dictionary<string, int>();
        foreach (var s in str.ToLower().Split(new char[] { ' ', '.' }, StringSplitOptions.RemoveEmptyEntries))
        {
            if (!dict.ContainsKey(s))
                dict.Add(s, 1);
            else
            {
                dict[s] += 1;
            }
        }

        for (int i = 0; i < 10; i++)
        {
            var keyOfMostFrequentWord = dict.MaxBy(s => s.Value).Key;
            result.Add(keyOfMostFrequentWord.ToString());
            dict.Remove(keyOfMostFrequentWord);
        }

        return result;
    }

    public static IEnumerable<KeyValuePair<char, int>> allCharacters(this string str)
    {
        var dict = new Dictionary<char, int>();
        foreach (var s in str.ToLower().ToCharArray())
        {
            if (!dict.ContainsKey(s))
                dict.Add(s, 1);
            else
            {
                dict[s] += 1;
            }
        }
        dict.Remove(' ');

        return dict.OrderByDescending(d => d.Value);
    }

}
