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
            Stack<double> OperandStack = new Stack<double>();
            foreach (var item in expression.Split(' '))
            {
                if (double.TryParse(item, out double operand))
                {
                    OperandStack.Push(operand);
                }
                else
                {
                    double op2 = OperandStack.Pop();
                    double op1 = OperandStack.Pop();
                    double output = Evaluate(op1, op2, item);
                    OperandStack.Push(output);
                }
            }
            return OperandStack.Pop();

        }
        public static  double Evaluate(double op1, double op2, string oper)
        {
            if(oper == "+")
            {
                return op1 + op2;
            }
            else
            {
                return 0;

            }
        }
    }


    public class Stack<T>
    {
        int count;
        T[] elements;

        public Stack()
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
