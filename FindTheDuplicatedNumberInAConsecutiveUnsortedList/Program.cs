using System.Linq;
namespace FindTheDuplicatedNumberInAConsecutiveUnsortedList
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine(FindDup(new int[] { 1, 2, 3, 3, 4, 5 }));
        }
        public static int FindDup(int[] arr)
        { 
            return arr.GroupBy(num => num).Where(g => g.Count() > 1).Select(num => num.Key).Single();
        }
    }
}