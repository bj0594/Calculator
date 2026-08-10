public static class CalculatorLogic
{
    // This method takes a string expression in the format "number1 operator number2"
    // and performs the calculation based on the operator.
    public static string Calculate(string expression)
    {
        // Find the index of the operator in the expression
        int operatorIndex = expression.IndexOfAny(['+', '-', '*', '/']);

        // If no operator is found, return the original expression
        if (operatorIndex == -1)
        {
            return expression; 
        }

        // Split the expression into two numbers based on the operator index
        string firstNumber = expression[..operatorIndex];
        string secondNumber = expression[(operatorIndex + 1)..];

        double first = double.Parse(firstNumber);
        double second = double.Parse(secondNumber);

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
                    return "Error";
                }
                return (first / second).ToString("0.##"); // Format to 2 decimal places
            default:
                return expression; // Unknown operator, return the original expression
        }
    }
}