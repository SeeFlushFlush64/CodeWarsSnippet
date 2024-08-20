string myString = "Michael Rhey Palaganas";
string[] words = myString.Split(' ');

foreach(string word in words)
{
    char[] reversible = word.ToCharArray();
    Array.Reverse(reversible);
    foreach(char letter in reversible)
    {
        Console.Write($"{letter}");
    }
    if(Array.IndexOf(words, word) != words.Length -1)
    {
        Console.Write(' ');
    }
}