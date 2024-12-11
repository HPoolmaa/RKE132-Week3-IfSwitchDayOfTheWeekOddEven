
// Kasutame switch funktsiooni

Console.WriteLine("This program will tell you what day of the week it is.");

int WeekDay = 10; // Convert.ToInt32(DateTime.Now.DayOfWeek); // väärtus on vahemikus 0-6
// Console.WriteLine(WeekDay);

switch (WeekDay) // Väärtus mida kontrollime
{
    case 0:  // Case 0 == if(WeekDay == 0)
        Console.WriteLine("It's Sunday!");
        break;
    case 1: 
        Console.WriteLine("It's Monday!");
        break; 
    case 2:
        Console.WriteLine("It's Tuesday!");
        break;
    case 3:
        Console.WriteLine("It's Wednesday!");
        break;
    case 4:
        Console.WriteLine("It's Thursday!");
        break;
    case 5:
        Console.WriteLine("It's Friday!");
        break;
    case 6:
        Console.WriteLine("It's Saturday!");
        break;
    default:
        Console.WriteLine("Your computer calendar program seems to be corrupted! Please throw the computer out of the window >:)");
        break;
}
Console.WriteLine("Have a nice day!");