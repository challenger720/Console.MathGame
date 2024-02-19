string? menuSelection;
string? answer;
Random random = new Random();
int number;
int point = 0;
bool verify;
bool showMenu = true;

while (showMenu)
{
    MainMenu();
    showMenu = MainMenu();
}

bool MainMenu()
{
    Console.Clear();
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
    } while ((menuSelection == null) || (menuSelection != "V" || menuSelection != "A" || menuSelection != "S" || menuSelection != "M" || menuSelection != "D" || menuSelection != "Q"));

    switch (menuSelection)
    {
        case "V":
            return true;
        case "A":
            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Addition();
            }
            Score();
            return true;
        case "S":
            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Subtraction();
            }
            Score();
            return true;
        case "M":
            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Multiply();
            }
            Score();
            return true;
        case "D":
            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Division();
            }
            Score();
            return true;
        case "Q":
            return false;
        default:
            return false;
    }
}

void Addition()
{
    int A = random.Next(1, 101);
    int B = random.Next(1, 101);
    int sum = A + B;
    Console.WriteLine("Addition game");
    Console.WriteLine($"{A} + {B}");
    do
    {
        answer = Console.ReadLine();
        verify = int.TryParse(answer, out number);
    } while ((answer == null) || (!verify));
    Check(number, sum);
}

void Subtraction()
{
    int A = random.Next(1, 101);
    int B = random.Next(1, 101);
    int sub = A - B;
    Console.WriteLine("Subtraction game");
    Console.WriteLine($"{A} - {B}");
    do
    {
        answer = Console.ReadLine();
        verify = int.TryParse(answer, out number);
    } while ((answer == null) || (!verify));
    Check(number, sub);
}

void Multiply()
{
    int A = random.Next(1, 101);
    int B = random.Next(1, 101);
    int product = A * B;
    Console.WriteLine("Multiplication game");
    Console.WriteLine($"{A} * {B}");
    do
    {
        answer = Console.ReadLine();
        verify = int.TryParse(answer, out number);
    } while ((answer == null) || (!verify));
    Check(number, product);
}

void Division()
{
    int A = 1;
    int B = 1;
    int remainder = 1;
    while (remainder != 0)
    {
        A = random.Next(1, 101);
        B = random.Next(1, 101);
        remainder = A % B;
    }
    int divide = A / B;
    Console.WriteLine("Division game");
    Console.WriteLine($"{A} / {B}");
    do
    {
        answer = Console.ReadLine();
        verify = int.TryParse(answer, out number);
    } while ((answer == null) || (!verify));
    Check(number, divide);
}

void Check(int input, int ans)
{
    if (input == ans)
    {
        Console.WriteLine("Your answer was correct! Type any key for the next question");
        point += 1;
    }
    else
        Console.WriteLine("Incorrect. Type any key for next question");
}

void Score()
{
    Console.WriteLine($"Game over. Your final score is {point}. Press any key to go back to main menu.");
}