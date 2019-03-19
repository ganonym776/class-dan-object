using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @class
{
    class mahasiswa
{
        //properties
        public string Nim { get; set;}
        public string Nama { get; set; }
        public float Ipk { get; set; }

        //method
        public void Registrasi()
        {
            Console.WriteLine("\n\nNama\t: {0}", Nama);
            Console.WriteLine("NIM\t: {0}", Nim);
            Console.WriteLine("IPK\t: {0}", Ipk);
            Console.WriteLine("\n\nTelah Melakukan Registrasi");
        }
        public void IsiKrs()
        {
            Console.WriteLine("{0} Sedang Melakukan Proses KRS\n", Nama);
        }
    }
}
