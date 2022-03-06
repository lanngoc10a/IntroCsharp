// See https://aka.ms/new-console-template for more information
string text = "Everyone said that it would not work. Then someone came, " +
                "unaware of what everyone said, and just did it.";

// Get the two capital letters out of the text (by using the [] operator). 
char a = text[0];
Console.WriteLine(a);

char d = text[38];
Console.WriteLine(d);

//Compare the text with your name and interpret the result (CompareTo).
int compare = text.CompareTo("Nguyen Ngoc Lan");
Console.WriteLine("Return value(comparison) = " + compare);

//string my_name = "Nguyen Ngoc Lan";
//Console.WriteLine("Return value (comparison) = " + text.CompareTo(my_name));

//Add your first name to the text (+).
Console.WriteLine("Add your first name to the text (+) = " + text+ "Nguyen");

//See if the words "did" and "CSharp" occur (Contains).
Console.WriteLine(text.Contains("did"));
Console.WriteLine(text.Contains("CSharp"));

//Compare two strings for equality (Equals or ==).
string first_string = "bicycle";
string second_string = "motorbicycle";
Console.WriteLine(first_string.Equals(second_string));

//Output the index of the first "d" in the text (IndexOf).
Console.WriteLine(text.IndexOf("d"));

//Check for the empty string "" (IsNullOrEmpty).
Console.WriteLine(string.IsNullOrEmpty(text));
Console.WriteLine(string.IsNullOrEmpty(""));

// Check if a string is null (IsNullOrEmpty). 
string myName = null;
bool nullString = string.IsNullOrEmpty(myName);
Console.WriteLine(nullString);

myName = "Name";
nullString = string.IsNullOrEmpty(myName);
Console.WriteLine(nullString);

// Output the length of the text (Length). 
int length = text.Length;
Console.WriteLine(length);

// Read the words "said" and "did" (Substring). 
string saidSubstr = text.Substring(9, 4);
Console.WriteLine(saidSubstr);

string didSubstr = text.Substring(text.Length - 7, 3);
Console.WriteLine(didSubstr);