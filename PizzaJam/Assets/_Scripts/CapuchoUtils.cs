using System.Collections.Generic;

public static class CapuchoUtils
{
    public static void ShuffleList<T>(this IList<T> list)
    {
        int n = list.Count;
        var rng = new System.Random();
        while (n > 1)
        {
            n--;
            int k = rng.Next(n + 1);
            (list[n], list[k]) = (list[k], list[n]);
        }
    }
}
