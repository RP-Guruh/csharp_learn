namespace BelajarFundamental.dasar
{
    public static class SwitchCase
    {
        public static void Running()
        {
            int day = 3; // Contoh hari dalam seminggu (1-7)

            switch (day)
            {
                case 1:
                    Console.WriteLine("Hari Senin");
                    break;
                case 2:
                    Console.WriteLine("Hari Selasa");
                    break;
                case 3:
                    Console.WriteLine("Hari Rabu");
                    break;
                case 4:
                    Console.WriteLine("Hari Kamis");
                    break;
                case 5:
                    Console.WriteLine("Hari Jumat");
                    break;
                case 6:
                    Console.WriteLine("Hari Sabtu");
                    break;
                case 7:
                    Console.WriteLine("Hari Minggu");
                    break;
                default:
                    Console.WriteLine("Input tidak valid, masukkan angka antara 1-7.");
                    break;
            }
        }
    }
}