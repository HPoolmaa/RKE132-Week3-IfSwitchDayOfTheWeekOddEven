Console.WriteLine("Write a number:");

int UserNum = Convert.ToInt32(Console.ReadLine());
// kasutaja sisestatud number on paaris või paaritu -arv

int Result = UserNum % 2;

// Console.WriteLine(Result);

if (Result != 0)
{
    Console.WriteLine("The number is odd");
}
else
{
    Console.WriteLine("The number is even");
}
