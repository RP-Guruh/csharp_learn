namespace BelajarFundamental.dasar
{
    public static class ManipulasiString
    {
        public static void Running()
        {
            /*
                1. Trim: Menghapus spasi di awal dan akhir string
                2. TrimStart: Menghapus spasi di awal string
                3. TrimEnd: Menghapus spasi di akhir string
                4. ToUpper: Mengubah string menjadi huruf kapital
                5. ToLower: Mengubah string menjadi huruf kecil
                6. Replace(old, new): Mengganti substring lama dengan yang baru
                7. Substring(start, length): Mengambil substring dari string
                8. IndexOf(substring): Mencari indeks dari substring
                9. LastIndexOf(substring): Mencari indeks terakhir dari substring
                10. Contains(substring): Mengecek apakah string mengandung substring
                11. StartsWith(prefix): Mengecek apakah string dimulai dengan prefix
                12. EndsWith(suffix): Mengecek apakah string diakhiri dengan suffix
            */
            string judul_film = "   avengers: endgame   ";
            Console.WriteLine($"Sebelum Trim: '{judul_film}'");
            Console.WriteLine($"Trim: {judul_film.Trim()}");
            Console.WriteLine($"TrimStart: {judul_film.TrimStart()}");
            Console.WriteLine($"TrimEnd: {judul_film.TrimEnd()}");
            Console.WriteLine($"ToUpper: {judul_film.ToUpper()}");
            Console.WriteLine($"ToLower: {judul_film.ToLower()}");
            judul_film = judul_film.Trim();
            Console.WriteLine(
                $"Upper First: {char.ToUpper(judul_film[0])}{judul_film.Substring(1)}"
            );
            Console.WriteLine(
                $"Lower First: {char.ToLower(judul_film[0])}{judul_film.Substring(1)}"
            );
            Console.WriteLine($"Replace: {judul_film.Replace("avengers: endgame", "Mr Bean")}");
            Console.WriteLine($"Substring: {judul_film.Substring(0, 8)}");
            Console.WriteLine($"IndexOf('endgame'): {judul_film.IndexOf("endgame")}");
            Console.WriteLine($"LastIndexOf('e'): {judul_film.LastIndexOf("e")}");
            Console.WriteLine($"Contains('naruto'): {judul_film.Contains("naruto")}");
            Console.WriteLine($"StartsWith('ave'): {judul_film.StartsWith("ave")}");
            Console.WriteLine($"EndsWith('endgame'): {judul_film.EndsWith("endgame")}");
           
        }
    }
}   