public static class BalancedBrackets
{
    public static bool AreBracketsBalanced(string expression)
    {
        Stack<char> stack = new();

        for (int i = 0; i < expression.Length; i++)
        {
            var isStartingBracket = expression[i] == '{' || expression[i] == '(' || expression[i] == '[';
            if (isStartingBracket)
                stack.Push(expression[i]);

            var isEndingBracket = expression[i] == '}' || expression[i] == ')' || expression[i] == ']';
            if (isEndingBracket)
            {
                var hasStartingBracketOnStack = stack.Count > 0;
                if (hasStartingBracketOnStack)
                {
                    var startBracket = stack.Pop();
                    var endBracket = expression[i];
                    if (!CheckIfEndBracketMatchesStartBracket(startBracket, endBracket)) return false;
                }
                else return false;
            }
        }

        if (stack.Count == 0)
            return true;
        else
        {
            return false;
        }
    }
    private static bool CheckIfEndBracketMatchesStartBracket(char startBracket,
                               char endBracket)
    {
        if (startBracket == '(' && endBracket == ')')
            return true;
        else if (startBracket == '{' && endBracket == '}')
            return true;
        else if (startBracket == '[' && endBracket == ']')
            return true;
        else
            return false;
    }
}