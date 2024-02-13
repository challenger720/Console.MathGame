string? menuSelection;
Console.WriteLine("What game would you like to play today? Choose from the options below:");
Console.WriteLine("V - View Previous Games");
Console.WriteLine("A - Addition");
Console.WriteLine("S - Subtraction");
Console.WriteLine("M - Multiplication");
Console.WriteLine("D - Division");
Console.WriteLine("Q - Quit the program");
Console.WriteLine("----------------------------------------------------------------------");

do
{
    menuSelection = Console.ReadLine();
} while (menuSelection == null && (menuSelection != "V" || menuSelection != "A" || menuSelection != "S" || menuSelection != "M" || menuSelection != "D" || menuSelection != "Q"));

Console.Clear();

switch (menuSelection)
{
    case "V":
        break;
    case "A":
        break;
    case "S":
        break;
    case "M":
        break;
    case "D":
        break;
    case "Q":
        break;
}