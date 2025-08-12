using BelajarFundamental.dasar;

class Program
{
    static void Main()
    {
        Console.WriteLine("Belajar Dasar C#");
        Console.WriteLine("1. Cetak Output di Console");
        Console.WriteLine("2. Interpolasi String");
        Console.WriteLine("3. Manipulasi String");
        Console.WriteLine("4. Operasi Matematika pada Bilangan Bulat");
        Console.WriteLine("5. IF Else");
        Console.WriteLine("6. Switch Case");
        Console.WriteLine("7. Perulangan");
        Console.WriteLine("8. Array, List, Dictionary, Tuple");
        Console.WriteLine("9. Exception Handling");
        Console.WriteLine("10. Class, Object, Inheritance, Polymorphism (Progress)");
        Console.WriteLine("11. Generic, Nullable, Dynamic (Progress)");
        Console.WriteLine("12. LINQ (Progress)");
        Console.WriteLine("13. Asynchronous Programming (Progress)");
        Console.WriteLine("14. File I/O (Progress)");
        Console.WriteLine("15. Unit Testing (Progress)");
        Console.WriteLine("CTRL + C untuk keluar");
        Console.WriteLine("=====================================");
        Console.Write("Masukkan pilihan (1,2,3,4,5,6,7,8,9,12): ");
        string pilihan = Console.ReadLine()!;

        Console.WriteLine("Output : \n");

        switch (pilihan)
        {
            case "1":
                Print.Running();
                break;
            case "2":
                Interpolasi.Running();
                break;
            case "3":
                ManipulasiString.Running();
                break;
            case "4":
                NumberIntegerMath.Running();
                break;
            case "5":
                Ifelse.Running();
                break;
            case "6":
                SwitchCase.Running();
                break;
            case "7":
                Perulangan.Running();
                break;
            case "8":
                ArrayListDictionaryTuple.Running();
                break;
            case "9":
                ExceptionHandling.Running();
                break;
            case "12":
                LinqDasar.Running();
                break;
            default:
                Console.WriteLine("Pilihan tidak valid.");
                Console.WriteLine("Silakan coba lagi.");
                break;

        }
        RestartChoice();
    }

    static void RestartChoice()
    {
        Console.Write("Tekan Enter untuk melanjutkan...");
        Console.ReadLine();
        Console.Clear();
        Main();
    }
}