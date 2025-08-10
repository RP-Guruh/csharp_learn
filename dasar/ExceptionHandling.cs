namespace BelajarFundamental.dasar
{
    public static class ExceptionHandling
    {
        public static void Running()
        {
            try
            {
                int[] angka = [1, 2, 3];
                Console.WriteLine($"Array angka indeks 2: {angka[2]}");

                Console.Write("Masukkan usia Anda: ");
                string input = Console.ReadLine()!;
                int usia = int.Parse(input);
                Console.WriteLine($"Usia Anda: {input}");
                
                Console.WriteLine($"Usia Anda dalam 5 tahun: {usia + 5}");

            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Terjadi kesalahan: " + ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Format input tidak valid: " + ex.Message);
            }
        }
    }
}