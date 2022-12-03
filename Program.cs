Console.WriteLine("input number 100 - 1000");
int num = Convert.ToInt32(Console.ReadLine());

int DelHunOne()
{
    int ten = num / 10 % 10;

    return (ten);
}
  if (num >999 || num <100 || num<0)
  {
    Console.WriteLine("error");
  }
else
{
int res = DelHunOne();
Console.WriteLine(res);

}