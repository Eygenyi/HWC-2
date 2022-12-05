Console.WriteLine("input any number");
int num = Convert.ToInt32(Console.ReadLine());
int Third(int find=0)
{
    while (num > 100)
    {find = num % 10; 
    num = num /10;}
    return (find);
}

if (num<100)
Console.WriteLine("No third digit");
else 
{
int r=Third();
Console.WriteLine(r);
}
