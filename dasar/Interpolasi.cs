namespace BelajarFundamental.dasar
{
    public static class Interpolasi
    {
        public static void Running()
        {
            string name = "Guruh";
            int age = 25;

            // Interpolasi string menggunakan $ sebelum string
            // jika mau mencetak { } gunakan {{ dan }}
            Console.WriteLine($"Nama saya adalah {name} dan saya berusia {age} {{tahun}}.");
        }
    }
}
