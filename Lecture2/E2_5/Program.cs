// Get a substring after or before a character    
string authors = "Everyone _said_ that it would not work.\n Then someone " +
                      "came, #UNAWARE# of what everyone said, and just did it.";

int first_index_first = authors.IndexOf("_"), first_index_second = authors.IndexOf("#");
int last_index_first = authors.LastIndexOf("_") - authors.IndexOf("_") + 1, last_index_second = authors.LastIndexOf("#") - authors.IndexOf("#") + 1;

string string_to_replace_first = authors.Substring(first_index_first, last_index_first);
string string_to_upper_first = authors.Substring(first_index_first + 1, last_index_first - 2);

string string_to_replace_second = authors.Substring(first_index_second, last_index_second);
string string_to_lower_second = authors.Substring(first_index_second + 1, last_index_second - 2);

string Result = authors.Replace(string_to_replace_first, string_to_upper_first.ToUpper()).Replace(string_to_replace_second, string_to_lower_second.ToLower());

Console.WriteLine(Result);
