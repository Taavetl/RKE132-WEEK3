int weekday = Convert.ToInt32(DateTime.Now.DayOfWeek);
//Console.WriteLine(weekday);
if (weekday == 0) 
{
    Console.WriteLine("Pyhapaev");
}
else if(weekday == 1)
{
    Console.WriteLine("Esmasp");
}
else if(weekday == 2)
{
    Console.WriteLine("teisip");
}
else if(weekday == 3)
{
    Console.WriteLine("kolmap");
}
else if(weekday == 4)
{
    Console.WriteLine("neljap");
}
else if(weekday == 5)
{
    Console.WriteLine("reede");
}
else 
{
    Console.WriteLine("laup");
}
