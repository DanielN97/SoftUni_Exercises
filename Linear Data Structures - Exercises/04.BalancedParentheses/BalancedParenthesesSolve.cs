namespace Problem04.BalancedParentheses
{
    using System;
    using System.Collections.Generic;

    public class BalancedParenthesesSolve : ISolvable
    {
        public bool AreBalanced(string parentheses)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char character in parentheses)
            {
                if (character == '(' || character == '[' || character == '{')
                {
                    stack.Push(character);
                }
                else if (stack.Count != 0)
                {
                    if (character == ')')
                    {
                        if (stack.Peek() == '(')
                        {
                            stack.Pop();
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else if (character == ']')
                    {
                        if (stack.Peek() == '[')
                        {
                            stack.Pop();
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else if (character == '}')
                    {
                        if (stack.Peek() == '{')
                        {
                            stack.Pop();
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                else
                {
                    return false;
                }
            }

            if (stack.Count != 0)
            {
                return false;
            }

            return true;
        }
    }
}
