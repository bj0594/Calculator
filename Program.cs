Console.Clear();
int row = 0;
int column = 0;

Console.WriteLine("7 8 9 /\n4 5 6 *\n1 2 3 -\n[0] . = +");

while (true)
{
    ConsoleKeyInfo input = Console.ReadKey();

    if (input.Key == ConsoleKey.Escape)
    {
        break;
    }

    switch (input.Key)
    {
        case ConsoleKey.UpArrow:
        row--;
        break;

        case ConsoleKey.DownArrow:
        row++;
        break;

        case ConsoleKey.LeftArrow:
        column--;
        break;

        case ConsoleKey.RightArrow:
        column++;
        break;
    }
}
Console.WriteLine($"Row: {row}, Column: {column}");