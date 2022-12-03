Console.WriteLine("input day number");
        int day = Convert.ToInt32(Console.ReadLine());

        void DayOfWeek()
        {

            if (day ==7 || day == 6)
                Console.WriteLine("EEEE day off");
            else
            {
                Console.WriteLine("Working day");
            }
        }
if (day >7 || day <1 || day==0)
  {
    Console.WriteLine("error");
  }
else
{
  
DayOfWeek ();
}
  

