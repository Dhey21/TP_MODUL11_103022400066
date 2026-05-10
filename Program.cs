using System;
using AljabarLibraries;

namespace TP_MODUL11_103022400066
{
    class Program
    {
        static void Main(string[] args)
        {

            double[] persamaanKuadrat = { 1, -3, -10 };
            double[] akar = Aljabar.AkarPersamaanKuadrat(persamaanKuadrat);
            Console.WriteLine($"AkarPersamaanKuadrat({{1, -3, -10}})");
            Console.WriteLine($"Output: {{{akar[0]}, {akar[1]}}}");
            Console.WriteLine();
            Console.WriteLine("Hasil Kuadrat ");
            double[] persamaanLinear = { 2, -3 };
            double[] hasil = Aljabar.HasilKuadrat(persamaanLinear);
            Console.WriteLine($"HasilKuadrat({2,-3})");
            Console.WriteLine($"Output: {hasil[0]}, {hasil[1]}, {hasil[2]}");
        }
    }
}