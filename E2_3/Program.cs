// See https://aka.ms/new-console-template for more information

int Add(int x1, int x2){
    int sum = x1 + x2;
    return sum;
}

int Multiply(int x1,int  x2){
    int multi = x1 * x2;
    return multi;
}

int Subtract(int x1, int x2)
{
    int minus = x1 - x2;
    return minus;
}

int Divide(int x1, int x2)
{
    int deling = x1/x2;
    return deling;
}

int result = 0;

result = Add(result, 8);
Console.WriteLine(result);

result = Multiply(result, 2);
Console.WriteLine(result);

result = Subtract(result, 4);
Console.WriteLine(result);

result = Divide(result, 3);
Console.WriteLine(result);

