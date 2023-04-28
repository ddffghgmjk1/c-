System.Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());
int max = 0;
int min = 0;
if(a<b)
{
    max=b;
    min=a;
}
if (a>b)
{
    max=a;
    min=b;
}

System.Console.WriteLine(max);
System.Console.WriteLine(min);