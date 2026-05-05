public static class SimpleCalculator
{
    public static string Calculate(int operand1, int operand2, string? operation)
    {
        int result = 0;

        if(operation == "/" && operand2 == 0)
        {
                return "Division by zero is not allowed.";
        }

        if(operation == null)
        {
            throw new ArgumentNullException("Operation cannot be null");
        }
        
        else if(operation == string.Empty)
        {
            throw new ArgumentException("Operation cannot be an empty string");
        }
        
       else if(operation == "+")
           {
               result = operand1 + operand2;
           }
       else if(operation == "*")
           {
               result = operand1 * operand2;
           }
       else if(operation == "/")
           {
               result = operand1 / operand2;
           }
        
        else
        {
            throw new ArgumentOutOfRangeException("Invalid operation");
        }
        
        return $"{operand1} {operation} {operand2} = {result}";
    }
}
