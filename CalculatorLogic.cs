public static class CalculatorLogic
{
    // This method takes a string expression in the format "number1 operator number2"
    // and performs the calculation based on the operator.
    public static string Calculate(string expression)
    {
        int operatorIndex = expression.IndexOfAny(['+', '-', '*', '/']);

        if (operatorIndex == -1)
        {
            return expression; // No operator found, return the original expression
        }

        // Split the expression into two numbers based on the operator index
        string firstNumber = expression[..operatorIndex];
        string secondNumber = expression[(operatorIndex + 1)..];

        double first = int.Parse(firstNumber);
        double second = int.Parse(secondNumber);

        // Perform the calculation based on the operator
        switch (expression[operatorIndex])
        {
            case '+':
                return (first + second).ToString();
            case '-':
                return (first - second).ToString();
            case '*':
                return (first * second).ToString();
            case '/':
                if (second == 0)
                {
                    return "Error: Division by zero";
                }
                return (first / second).ToString("0.##"); // Format to 2 decimal places
            default:
                return expression; // Unknown operator, return the original expression
        }
    }
}