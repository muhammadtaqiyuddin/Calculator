using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare variables and then initialize to zero
            int num1 = 0;
            int num2 = 0;

            // Display title as the C# console calculator.app
            Console.WriteLine("Console Calculator in C#\r");
            Console.WriteLine("------------/n");

            // Ask the user to type the first number.
            Console.WriteLine("Masukkan angka, dan tekan Enter");
            num1 = Convert.ToInt32(Console.ReadLine());

            // Ask the user to type the second number.
            Console.WriteLine("Masukkan angka berikutnya, dan tekan Enter");
            num2 = Convert.ToInt32((Console.ReadLine()));

            // Ask the user to choose an option.
            Console.WriteLine("Silahkan pilih opsi dari list berikut : ");
            Console.WriteLine("\ta - Tambah");
            Console.WriteLine("\ts - Pengurangan");
            Console.WriteLine("\tm - Perkalian");
            Console.WriteLine("\td - Pembagian");
            Console.Write("Pilihan Anda?");

            // Use a switch statement to do the math.
            switch (Console.ReadLine())
            {
                case "a":
                    Console.WriteLine($"Hasil:{num1}+{num2}=" +(num1 + num2));
                    break;
                case "s":
                    Console.WriteLine($"Hasil:{num1}-{num2}=" + (num1 - num2));
                    break;
                case "m":
                    Console.WriteLine($"Hasil:{num1}*{num2}=" + (num1 * num2));
                    break;
                case "d":
                    Console.WriteLine($"Hasil:{num1}/{num2}=" + (num1 / num2));
                    break;
            }

            // Wait for the user to respond before closing.
            Console.WriteLine("Tekan tombol apapun untuk menutup aplikasi...");
            Console.ReadKey();
        }
    }
}