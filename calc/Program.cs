namespace calc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("1 число: ");
            double one = Convert.ToDouble(Console.ReadLine());
            Console.Write("Оператор: ");
            char oper = Convert.ToChar(Console.ReadLine());
            Console.Write("2 число: ");
            double two = Convert.ToDouble(Console.ReadLine());
            double result = 0;
            if (oper == '+') result = Calculator.Sum(one, two);
            else if (oper == '-') result = Calculator.Sub(one, two);
            else if (oper == '*') result = Calculator.Mul(one, two);
            else if (oper == '/') result = Calculator.Div(one, two);
            else Calculator.Result();
            Console.WriteLine(result);
        }
    }
    public static class Calculator
    {
        public static double Sum(double x, double y)
        {
            double sum;
            sum = x + y;
            return sum;
        }
        public static double Sub(double x, double y)
        {
            double sub;
            sub = x - y;
            return sub;
        }
        public static double Mul(double x, double y)
        {
            double mul;
            mul = x * y;
            return mul;
        }
        public static double Div(double x, double y)
        {
            double div = 0;
            try
            {
                div = x / y;
            }
            catch (DivideByZeroException) { }
            return div;
        }
        public static string Result()
        {
            return "Введен неверный оператор";
        }
    }
}