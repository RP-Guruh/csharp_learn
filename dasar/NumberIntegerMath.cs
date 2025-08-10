namespace BelajarFundamental.dasar
{
    public static class NumberIntegerMath
    {
        public static void Running()
        {
            /*
                1. int
                2. double
                3. float
                4. decimal
            */
            int a = 10;
            int b = 20;
            Console.WriteLine($"a = {a}, b = {b}");
            Console.WriteLine($"a + b = {a + b}");
            Console.WriteLine($"a - b = {a - b}");
            Console.WriteLine($"a * b = {a * b}");
            Console.WriteLine($"a / b = {a / b}");
            Console.WriteLine($"a % b = {a % b}");

            int maxA = int.MaxValue;
            int minA = int.MinValue;
            Console.WriteLine($"Max int: {maxA}");
            Console.WriteLine($"Min int: {minA}");

            double c = 10.5;
            double d = 20.5;
            Console.WriteLine($"c = {c}, d = {d}");
            Console.WriteLine($"c + d = {c + d}");
            Console.WriteLine($"c - d = {c - d}");
            Console.WriteLine($"c * d = {c * d}");
            Console.WriteLine($"c / d = {c / d}");
            Console.WriteLine($"c % d = {c % d}");

            double maxC = double.MaxValue;
            double minC = double.MinValue;
            Console.WriteLine($"Max double: {maxC}");
            Console.WriteLine($"Min double: {minC}");       
            

        }
    }
}