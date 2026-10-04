//jar, jam

public class Solution {
    public bool IsAnagram(string s, string t)
{
    Dictionary<char, int> seenS = new();
    Dictionary<char, int> seenT = new();

    foreach (char c in s)
    {
        if (seenS.ContainsKey(c))
        {
            seenS[c]++;
        }
        else
        {
            seenS.Add(c, 1);
        }
    }

    foreach (char c in t)
    {
        if (seenT.ContainsKey(c))
        {
            seenT[c]++;
        }
        else
        {
            seenT.Add(c, 1);
        }
    }

    if (seenS.Count != seenT.Count)
    {
        return false;
    }

    foreach (var kvp in seenS)
    {
        if (!seenT.ContainsKey(kvp.Key) || seenT[kvp.Key] != kvp.Value)
        {
            return false;
        }
    }

    return true;
    }
}
