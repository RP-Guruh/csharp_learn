namespace BelajarFundamental.dasar
{
    public static class Perulangan
    {
        public static void Running()
        {
            /*
                1. for
                2. while
                3. do while
                4. foreach
            */

            // Contoh perulangan for
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Perulangan for ke-{i}");
            }

            // Contoh perulangan while
            int j = 0;
            while (j < 5)
            {
                Console.WriteLine($"Perulangan while ke-{j}");
                j++;
            }

            // Contoh perulangan do while
            int k = 0;
            do
            {
                Console.WriteLine($"Perulangan do while ke-{k}");
                k++;
            } while (k < 5);

            // Contoh perulangan foreach
            string[] names = { "Guruh", "Budi", "Siti" };
            foreach (var name in names)
            {
                Console.WriteLine($"Nama: {name}");
            }
        }
    }
}