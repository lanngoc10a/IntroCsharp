// See https://aka.ms/new-console-template for more information


string bio = "Mahesh Chand is a founder of C# Corner. Mahesh is also an author, speaker, and software architect. Mahesh founded C# Corner in 2000.";

// Get first 12 characters substring from a string        
string authorName = bio.Substring(0, 12);
Console.WriteLine(authorName);

// Get everything else after 12th position     
string authorBio = bio.Substring(12);
Console.WriteLine(authorBio);


// Get a substring before a character    
string authors = "Mahesh Chand, Henry He, Chris Love, Raj Beniwal, Praveen Kumar";
string stringBeforeChar = authors.Substring(0, authors.IndexOf(","));
Console.WriteLine(stringBeforeChar);

// Get a substring after a character     
string stringafterchar = authors.Substring(authors.IndexOf(",") + 0);
Console.WriteLine(stringafterchar);


string replacing_word(string s)
{
    if (s.Substring(s.IndexOf("_"), s.LastIndexOf("_")) = "said")
        {
        return "a";
    }
}

example_list = "Everyone _said_ that it would not work.\n Then someone came, #UNAWARE# of what everyone said, and just did it."

Console.WriteLine(replacing_word(example_list));
