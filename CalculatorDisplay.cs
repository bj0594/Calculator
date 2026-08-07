public static class CalculatorDisplay
{
    public static void DrawButton(string text, bool selected)
    {
        if (selected)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
        }

        Console.Write($" {text} ");

        Console.ResetColor();
    }
    public static void Draw(int row, int column)
    {
        Console.WriteLine("╔═══════════════╗");
        Console.WriteLine("║               ║");
        Console.WriteLine("╠═══╦═══╦═══╦═══╣");
        Console.Write("║");
        DrawButton("7", row == 0 && column == 0);
        Console.Write("║");
        DrawButton("8", row == 0 && column == 1);
        Console.Write("║");
        DrawButton("9", row == 0 && column == 2);
        Console.Write("║");
        DrawButton("/", row == 0 && column == 3);
        Console.WriteLine("║");
        Console.WriteLine("╠═══╬═══╬═══╬═══╣");
        Console.Write("║");
        DrawButton("4", row == 1 && column == 0);
        Console.Write("║");
        DrawButton("5", row == 1 && column == 1);
        Console.Write("║");
        DrawButton("6", row == 1 && column == 2);
        Console.Write("║");
        DrawButton("*", row == 1 && column == 3);
        Console.WriteLine("║");
        Console.WriteLine("╠═══╬═══╬═══╬═══╣");
        Console.Write("║");
        DrawButton("1", row == 2 && column == 0);
        Console.Write("║");
        DrawButton("2", row == 2 && column == 1);
        Console.Write("║");
        DrawButton("3", row == 2 && column == 2);
        Console.Write("║");
        DrawButton("-", row == 2 && column == 3);
        Console.WriteLine("║");
        Console.WriteLine("╠═══╬═══╬═══╬═══╣");
        Console.Write("║");
        DrawButton("0", row == 3 && column == 0);
        Console.Write("║");
        DrawButton(".", row == 3 && column == 1);
        Console.Write("║");
        DrawButton("=", row == 3 && column == 2);
        Console.Write("║");
        DrawButton("+", row == 3 && column == 3);
        Console.WriteLine("║");
        Console.WriteLine("╚═══╩═══╩═══╩═══╝");
    }
}

