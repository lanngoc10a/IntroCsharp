
// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

static int SearchArray(string searchWord, string[] arrayToSearch)
{
    if (arrayToSearch.Contains(searchWord))
        return Array.IndexOf(arrayToSearch, searchWord);
    else
        return -1;
}


string[] fruits = { "Apple", "Banana", "Grape", "Orange", "Pear", "Watermelon" };
string word = "Banana";

Console.WriteLine(SearchArray(word, fruits).ToString());