namespace Calculator.DAL
{
    public class CalculatorDAL
    {
        public static int Sum(int val1, int val2)
        {
            int result = val1 + val2;
            return result;
        }

        public static int Subtraction(int val1, int val2)
        {
            int result = val1 - val2;
            return result;
        }

        public static int Multiplication(int val1, int val2)
        {
            int result = val1 * val2;
            return result;
        }

        public static int Division(int val1, int val2)
        {
            int result = val1 / val2;
            return result;
        }
    }
}