int weekday = Convert.ToInt32(DateTime.Now.DayOfWeek);

if (weekday == 0)
{
    Console.WriteLine("Pyhapaev");
}
else if (weekday == 1)
{
    Console.WriteLine("Esmasp");
}
else if (weekday == 2)
{
    Console.WriteLine("teisip");
}
else if (weekday == 3)
{
    Console.WriteLine("kolmap");
}
else if (weekday == 4)
{
    Console.WriteLine("neljap");
}
else if (weekday == 5)
{
    Console.WriteLine("reede");
}
else
{
    Console.WriteLine("laup");
}

switch(weekday)
{
    case 0:
        Console.WriteLine("Pyhap");
        break;
    case 1:
        Console.WriteLine("esmasp");
        break;
    case 2:
        Console.WriteLine("teisip");
        break;
    case 3:
        Console.WriteLine("kolmap");
        break;
    case 4:
        Console.WriteLine("nelajap");
        break;
    case 5:
        Console.WriteLine("reede");
        break;
    case 6:
        Console.WriteLine("laup");
        break;

    default:
        Console.WriteLine("midagi l2ks valesti");
        break;

}

