Console.WriteLine("Insert string");

var input = Console.ReadLine();
if (input is null)
{
    Console.WriteLine("An input string must be provided"); Environment.Exit(0);
}

if (BalancedBrackets.AreBracketsBalanced(input))
    Console.WriteLine("Balanced ");
else
    Console.WriteLine("Not Balanced ");
