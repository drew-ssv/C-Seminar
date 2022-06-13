// a = 5; b = 7 -> max = 7 и a = 2 b = 10 -> max = 10 и a = -9 b = -3 -> max = -3
Console.Write("Input number a: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Input number b: ");
int b = Convert.ToInt32(Console.ReadLine());
int max;
max = a;
if (max > b)
{
    Console.WriteLine("The MAX number is ->" + a);
}
else if (a == b)
{
    Console.WriteLine("The numbers are -> IDENTICAL");
}
else
{
  Console.WriteLine("The MAX number is ->" + b);
}  
