using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @class
{
    class Program
    {
        static void Main(string[] args)
        {
            mahasiswa baru = new mahasiswa();

            Console.Write("Masukkan Nama\t: ");
            baru.Nama = Console.ReadLine();
            Console.Write("Masukkan NIM \t: ");
            baru.Nim = Console.ReadLine();
            Console.Write("Masukkan IPK\t: ");
            baru.Ipk = float.Parse(Console.ReadLine());

            baru.Registrasi();
            baru.IsiKrs();
            Console.ReadKey();
        }
    }
}
