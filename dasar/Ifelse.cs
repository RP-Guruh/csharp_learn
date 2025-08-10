namespace BelajarFundamental.dasar
{
    public static class Ifelse
    {
        public static void Running()
        {
            /*
                1. if
                2. else
                3. else if
            */
            int a = 10;
            int b = 20;

            // Contoh if-else
            if (a > b)
            {
                Console.WriteLine("a lebih besar dari b");
            }
            else if (a < b)
            {
                Console.WriteLine("a lebih kecil dari b");
            }
            else
            {
                Console.WriteLine("a sama dengan b");
            }
        }
    }
}