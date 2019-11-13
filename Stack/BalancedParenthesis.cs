using DataStructurePrograms.Stack;
using System;

public class BalancedParenthesis
{
    /// <summary>
    /// Checked the balance parenthesis.
    /// </summary>
    /// <returns>boolean type</returns>
    public void CheckExpressionBalancedOrNot()
    {
        Console.WriteLine("Enter Arithmatic Expression for checked");
        string expression = Console.ReadLine();
        char[] expressioncharArray = expression.ToCharArray();
        int size = expressioncharArray.Length;
        CheckedBalanceParenthesis(expressioncharArray);
        
    
    }
    public bool CheckedBalanceParenthesis( char[] expressioncharArray)
    {
       
        Stack stack = new Stack(expressioncharArray.Length);
        //// i is increment util size is greater
        // traverse the input expression
        for (int i = 0; i < expressioncharArray.Length; i++)
        {
            // if current char in the expression is a opening brace,
            // push it to the stack
            if (expressioncharArray[i] == '(' || expressioncharArray[i] == '{' || expressioncharArray[i] == '[')
            {
                stack.Push(expressioncharArray[i]);
            }

            // if current char in the expression is a closing brace
            if (expressioncharArray[i] == ')' || expressioncharArray[i] == '}' || expressioncharArray[i] == ']')
            {
                // return false if mismatch is found (i.e. if stack is
                // empty, the number of opening braces is less than number
                // of closing brace, so expression cannot be balanced)
                if (stack.IsStackEmpty())
                {
                    return false;
                }

                // pop character from the stack
                int top = stack.Pop();
                stack.Pop();

                // if the popped character if not an opening brace or does
                // not pair with current character of the expression
                if ((top == '(' && expressioncharArray[i] != ')') ||
                    (top == '{' && expressioncharArray[i] != '}') ||
                    (top == '[' && expressioncharArray[i] != ']'))
                {

                    return false;
                }
            }
        }
        //// check stack is empty or not
        if (stack.IsStackEmpty())
        {
            Console.WriteLine("Expression is Balanced");
        }
        else
        {
            Console.WriteLine("Expression is not Balanced");
        }

        return true;
    }
}
