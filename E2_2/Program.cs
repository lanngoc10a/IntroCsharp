List<int> ExtractEvenNumbersFromArray(int[] array)// => array.Where(x => x %2==0).ToArray();
{
    var list = new List<int>();
    foreach (int element in array)
    {
        if (element % 2 == 0)
        {
            list.Add(element);
        }
    }
    return list;
}



int[] numberArray = { 9, 2, 2, 0, 9, 3, 9, 4 };
Console.WriteLine("Array contains:");
foreach (int element in numberArray)
{
    Console.Write(element + ", ");
}
Console.WriteLine("\n");

List<int> evenNumberList = ExtractEvenNumbersFromArray(numberArray);

Console.WriteLine("the even numbers are:");
foreach (int element in evenNumberList)
{
    Console.Write(element + ", ");
}
Console.WriteLine();

