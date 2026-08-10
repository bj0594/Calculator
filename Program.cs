Console.Clear();

int row = 3;
int column = 0;

string display = "";

while (true)
{
    Console.Clear();

    Console.WriteLine("Welcome to the Terminal Calculator!");
    Console.WriteLine("Use arrow keys to move the cursor.");
    Console.WriteLine("Press Enter to choose your input, and ESC to exit.");

    CalculatorDisplay.Draw(row, column, display);

    ConsoleKeyInfo input = Console.ReadKey(true);

    if (input.Key == ConsoleKey.Escape)
    {
        Console.Clear();
        break;
    }

    switch (input.Key)
    {
        case ConsoleKey.UpArrow:
            if (row > 0)
                row--;
            break;

        case ConsoleKey.DownArrow:
            if (row < 3)
                row++;
            break;

        case ConsoleKey.LeftArrow:
            if (column > 0)
                column--;
            break;

        case ConsoleKey.RightArrow:
            if (column < 3)
                column++;
            break;

        case ConsoleKey.Enter:
            string button = CalculatorDisplay.GetButton(row, column);
            if (button == "C")
            {
                display = "";
            }
            else
            {
                display += button;
            }
            break;
    }
}