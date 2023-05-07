Console.WriteLine("Whats the cost of the item?");
double cost = double.Parse(Console.ReadLine());
Console.WriteLine("Whats the money given?");
double moneyGiven = double.Parse(Console.ReadLine());
if (cost > moneyGiven)
    Console.WriteLine("insufficient funds");
else
{
    double change = moneyGiven - cost;
    Console.WriteLine($"The change is {change:F2}$"); 

    double dollars = Math.Floor(change / 1);
    Console.WriteLine($"The number of dollars is {dollars}");
    change = change - dollars * 1;

    double quarters = Math.Floor(change / 0.25);
    Console.WriteLine($"The number of quarters is {quarters}");
    change = change - (quarters * 0.25) ;

    double dimes = Math.Floor(change / 0.10);
    Console.WriteLine($"The number of dimes is {dimes}");
    change = change - dimes * 0.10;

    double nickels = Math.Floor(change / 0.05);
    Console.WriteLine($"The number of nickels is {nickels}");
    change = change - nickels * 0.05;

    double pennies = Math.Floor(change / 0.01);
    Console.WriteLine($"The number of pennies is {pennies}");
    change = change - pennies * 0.01;
}