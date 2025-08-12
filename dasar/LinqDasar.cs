namespace BelajarFundamental.dasar
{
   

    public static class LinqDasar
    {
        public static void Running() {
            int[] randomNumber = [1, 4, 6, 7, 2, 3, 1, 10, 100];

            var karyawan = new List<(int Id, string Nama, decimal Gaji)>();
            var alamatKaryawan = new List<(int Id, int IdKaryawan, string Alamat)>();

            alamatKaryawan.Add((1, 1, "Jl. Kebon Jeruk"));
            alamatKaryawan.Add((2, 2, "Jl. Kebon Sirih"));
            alamatKaryawan.Add((3, 3, "Jl. Kebon Salak"));
            alamatKaryawan.Add((4, 4, "Jl. Kebon Semangka"));  
            
            karyawan.Add((1, "John Doe", 1500000));
            karyawan.Add((2, "Jane Smith", 1700000));
            karyawan.Add((3, "Alice Johnson", 1200000));
            karyawan.Add((4, "Bob Brown", 1800000));

            // test join
            var resultJoin =
                from emp in karyawan
                join addr in alamatKaryawan 
                on emp.Id equals addr.IdKaryawan
                select new {
                    Nama = emp.Nama,
                    Alamat = addr.Alamat
                };

            foreach (var item in resultJoin) {
                Console.WriteLine($"Nama: {item.Nama}, Alamat: {item.Alamat}");
            }


            var result = 
                from p in karyawan
                where p.Gaji > 1500000
                orderby p.Gaji descending
                select p.Nama;

            foreach (var item in result) {
                Console.WriteLine(item);
            }

            var result2 = 
                karyawan.Where(p => p.Gaji > 1500000)
                       .OrderByDescending(p => p.Gaji)
                       .Select(p => p.Nama);

            foreach (var item in result2) {
                Console.WriteLine(item);
            }

            // Query Syntax
            IEnumerable<int> query = 
                from number in randomNumber
                where number > 4
                orderby number descending
                select number;
            
            foreach (var number in query) {
                Console.WriteLine(number);
            }

            // Method syntax
            IEnumerable<int> method = 
                randomNumber.Where(number => number > 4)
                            .OrderByDescending(n => n );

            foreach (var number in method) {
                Console.WriteLine(number);
            }
            
        }
    }
}