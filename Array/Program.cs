using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // membuat array sekaligus inisialisasi nilai
            string[] arrNama = { "Nizar", "Kukuh", "jeeee", "Fisan" };
            int[] arrNim = { 4813, 4865, 4823, 4878 };
            int[] arrNilai = { 89, 90, 85, 98 };

            Console.WriteLine("===============================");
            Console.WriteLine("No\tNama\tNIM\tNilai");
            Console.WriteLine("===============================");

            //menampilkan semua elemen array
            for (int i = 0; i < arrNama.Length; i++)
            {
                Console.WriteLine((i + 1) + ".\t" + arrNama[i] + "\t" + arrNim[i] + "\t  " + arrNilai[i]);
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape) { }
        }
    }
}
