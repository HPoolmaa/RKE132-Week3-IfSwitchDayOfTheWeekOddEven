//teh. ülesanne
// Rakendus tuvastab mis nädalapäev täna on
// Algandmed võetakse arvutist

Console.WriteLine("This program will tell you what day of the week it is.");

int WeekDay = Convert.ToInt32(DateTime.Now.DayOfWeek);
// Console.WriteLine(WeekDay);

if (WeekDay == 0)
{
    Console.WriteLine("It is Sunday!");
}
else if (WeekDay == 1)
{
    Console.WriteLine("It is Monday!");
}
else if (WeekDay == 2)
{
    Console.WriteLine("It is Tuesday!");
}
else if (WeekDay == 3)
{
    Console.WriteLine("It is Wendnesday!");
}
else if (WeekDay == 4)
{
    Console.WriteLine("It isThursday!");
}
else if (WeekDay == 5)
{
    Console.WriteLine("It is Friday!");
}
else if(WeekDay == 6)
{
    Console.WriteLine("It is Saturday!");
}
Console.WriteLine("Have a nice day!");