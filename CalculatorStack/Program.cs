namespace CalculatorStack
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your calculation.");

            var input = Console.ReadLine();

            string[]? elements = input.Split(' ');
            var s = new Stack<string>(elements);

            var topLevelNode = BuildNode(s.Pop(), s);

            Console.WriteLine(topLevelNode.GetValue());
        }

        public static INode BuildNode(string next, Stack<string> s)
        {
            switch (next)
            {
                case "*":
                    return new MultiplicationNode(BuildNode(s.Pop(), s), BuildNode(s.Pop(), s));
                case "+":
                    return new AdditionNode(BuildNode(s.Pop(), s), BuildNode(s.Pop(), s));
                default:
                    return new NumberNode(Convert.ToDecimal(next));
            }
        }
    }
}