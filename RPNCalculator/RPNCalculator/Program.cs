using System;

namespace RPNCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, this is RPN calculator");
            string expression = "2 3 +";
            double expectedOutput = 5;
            double output = PostfixEvaluator(expression);
            Console.WriteLine("Expression: {0}", expression);
            Console.WriteLine("Expected output: {0}", expectedOutput);
            Console.WriteLine("Output: {0}", output);

        }
        static double PostfixEvaluator(string expression)
        {
            return 0;
        }
    }

    public class Stack<T>
    {
        int count;
        T[] elements;

        Stack()
        {
            count = 0;
            elements = new T[10];
        }

        public void Push(T value)
        {
            elements[count] = value;
            count++;
        }

        public T Pop()
        {
            count--;
            return elements[count];
        }
    }
}
