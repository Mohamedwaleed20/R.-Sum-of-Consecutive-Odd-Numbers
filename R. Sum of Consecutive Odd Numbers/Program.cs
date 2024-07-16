// See https://aka.ms/new-console-template for more information
int t = int.Parse(Console.ReadLine());
for (int x = 0; x < t; x++)
{
    int num1 = int.Parse(Console.ReadLine());
    int num2 = int.Parse(Console.ReadLine());
    int min = Math.Min(num1,num2);
    int max = Math.Max(num1,num2);
    int sum = 0;
    for (int y = min; y <= max; y++)
    {
        if (y % 2 != 0)
        {
            sum += y;
        }
        else if (max-min==1)
        {
            sum = 0;
        }

    }
    Console.WriteLine(sum);
    Console.WriteLine(" ");
}
Console.ReadLine();
