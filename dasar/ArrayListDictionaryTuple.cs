namespace BelajarFundamental.dasar
{
    public static class ArrayListDictionaryTuple
    {
        public static void Running()
        {
            Console.WriteLine("Array");
            // Array (nilai tetap)
            string[] namaHari;
            int[] angkaGenap = [10, 2, 8, 4, 10];
            namaHari = [ "Senin", "Selasa", "Rabu", "Kamis", "Jumat",
                                  "Sabtu", "Minggu" ];
            Console.WriteLine($"Array angka genap indeks 0: {angkaGenap[0]}");
            Console.WriteLine($"Array nama hari indeks 3: {namaHari[3]}");
            //Menampilkan semua elemen array
            foreach (var angka in angkaGenap)
            {
                Console.WriteLine($"Angka genap: {angka}");
            }

            Console.WriteLine("\nList");
            // List (nilai dinamis)
            List<int> angkaGanjil = new List<int>();
            // List<int> angkaGanjil = [1, 3, 5, 7]; // Inisialisasi dengan nilai awal
            angkaGanjil.Add(1);
            angkaGanjil.Add(3);
            angkaGanjil.Add(5);
            angkaGanjil.Add(7);
            Console.WriteLine($"List angka ganjil indeks 2: {angkaGanjil[2]}");
            // Menampilkan semua elemen list
            foreach (var angka in angkaGanjil)
            {
                Console.WriteLine($"Angka ganjil: {angka}");
            }
            angkaGanjil.Remove(5); // Menghapus angka 5 dari list
            angkaGanjil.RemoveAt(0); // Menghapus elemen pertama (indeks 0) 
            Console.WriteLine("Setelah penghapusan:");
            foreach (var angka in angkaGanjil)
            {
                Console.WriteLine($"Angka ganjil: {angka}");
            }

            Console.WriteLine("\nDictionary");
            // Dictionary (key-value pair)
            Dictionary<string, int> stokBarang = new Dictionary<string, int>();
            // Menambahkan data ke dalam dictionary
            stokBarang.Add("Pensil", 20);
            stokBarang.Add("Buku", 15);
            stokBarang.Add("Penghapus", 10);
            // Mengakses data berdasarkan key
            Console.WriteLine($"Stok Pensil: {stokBarang["Pensil"]}");
            // Menampilkan semua data dalam dictionary
            foreach (var item in stokBarang)
            {
                Console.WriteLine($"Barang: {item.Key}, Stok: {item.Value}");
            }
            // Menghapus data dari dictionary
            stokBarang.Remove("Penghapus");
            Console.WriteLine("Setelah penghapusan Penghapus:");
            foreach (var item in stokBarang)
            {
                Console.WriteLine($"Barang: {item.Key}, Stok: {item.Value}");
            }

            Console.WriteLine("\nTuple");
            // Tuple (nilai tetap, tidak bisa diubah)
            // Tuple digunakan untuk mengelompokkan beberapa nilai
            // TUple dapat dikombinasikan dengan List atau Dictionary
            var dataKaryawan = (Id: 1, Nama: "John Doe", Posisi: "Software Engineer");
            Console.WriteLine($"ID Karyawan: {dataKaryawan.Id}");
            Console.WriteLine($"Nama Karyawan: {dataKaryawan.Nama}");
            Console.WriteLine($"Jabatan Karyawan: {dataKaryawan.Posisi}");

            var daftarKaryawanList = new List<(int Id, string Nama, string Posisi)>();
            daftarKaryawanList.Add((2, "Jane Smith", "Data Analyst"));
            daftarKaryawanList.Add((3, "Alice Johnson", "Project Manager"));

            foreach (var karyawan in daftarKaryawanList)
            {
                Console.WriteLine($"ID Karyawan: {karyawan.Id}, Nama: {karyawan.Nama}, Posisi: {karyawan.Posisi}");
            }

        }
    }
}