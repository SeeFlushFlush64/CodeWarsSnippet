List<int> odds = new List<int>();
List<int> evens = new List<int>();
int[] integers = new int[]
{
    -5, 6, 6
};
foreach (int i in integers)
{
    if (i % 2 == 0)
    {
        odds.Add(i);
    }
    else
    {
        evens.Add(i);
    }
}
int outlier = odds.Count > evens.Count ? evens[0] : odds[0];
Console.WriteLine(outlier);