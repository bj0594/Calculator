Console.Clear();

// Initialize the cursor position, display string and maximum display length
int row = 3;
int column = 0;
const int MaxDisplayLength = 13;

// Initialize the display string
string display = "";

// Method to draw the calculator screen
void DrawScreen()
    {
        Console.Clear();
        Console.WriteLine("Welcome to the Terminal Calculator!");
        Console.WriteLine("Use arrow keys to move the cursor.");
        Console.WriteLine("Press Enter to choose your input, and ESC to exit.");

        CalculatorDisplay.Draw(row, column, display);
    }

// Main loop to handle user input and update the display
while (true)
{
    DrawScreen();

    ConsoleKeyInfo input = Console.ReadKey(true);

    // Exit the program if the Escape key is pressed
    if (input.Key == ConsoleKey.Escape)
    {
        Console.Clear();
        break;
    }

    // Handle cursor movement and button selection based on user input
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
            else if (button == "=")
            {
                display = CalculatorLogic.Calculate(display);
                DrawScreen();
                Thread.Sleep(2000);

                display = "";
                break;
            }
            else
            {
                if (display.Length < MaxDisplayLength)
                {
                display += button;
                }
            }
            break;
    }
}