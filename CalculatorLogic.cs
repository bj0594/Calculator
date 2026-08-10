public static class CalculatorLogic
{
    // Receives the expression from Program.cs
    // and prepares the values for the calculation.
    public static string Calculate(string expression)
    {
        // Find the first operator
        int operatorIndex = expression.IndexOfAny(['+', '-', '*', '/']);

        // If no operator is found, return the original expression
        if (operatorIndex == -1)
        {
            return expression;
        }

        // Find the operator
        char operation = expression[operatorIndex];

        // Split the expression into numbers
        string[] numberStrings = expression.Split(operation);

        // Convert the numbers from strings to doubles
        List<double> numbers = new List<double>();

        foreach (string number in numberStrings)
        {
            numbers.Add(double.Parse(number));
        }

        // If there are only two numbers, use the two-number overload
        if (numbers.Count == 2)
        {
            double result = Calculate(numbers[0], numbers[1], operation);
            return result.ToString("0.##");
        }

        // If there are more than two numbers, use the list overload
        double listResult = Calculate(numbers, operation);
        return listResult.ToString("0.##");
    }


    // Overload 1:
    // Calculates an operation between two numbers.
    public static double Calculate(double first, double second, char operation)
    {
        switch (operation)
        {
            case '+':
                return first + second;

            case '-':
                return first - second;

            case '*':
                return first * second;

            case '/':
                if (second == 0)
                {
                    return double.NaN; // Return NaN for division by zero
                }

                return first / second;

            default:
                throw new ArgumentException("Unknown operator");
        }
    }


    // Overload 2:
    // Calculates an operation using multiple numbers.
    public static double Calculate(List<double> numbers, char operation)
    {
        double result = numbers[0];

        for (int i = 1; i < numbers.Count; i++)
        {
            result = Calculate(result, numbers[i], operation);
        }

        return result;
    }
}