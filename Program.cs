using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Mahasiswa mhs1 = new Mahasiswa();
            mhs1.nim = "12344";
            mhs1.nama = "Erik";
            mhs1.nilai = "75";

            Mahasiswa mhs2 = new Mahasiswa();
            mhs2.nim = "12345";
            mhs2.nama = "Wely";
            mhs2.nilai = "80";

            Mahasiswa mhs3 = new Mahasiswa();
            mhs3.nim = "12346";
            mhs3.nama = "Sony";
            mhs3.nilai = "95";

            Mahasiswa[] arrMhs = new Mahasiswa[3];
            arrMhs[0] = mhs1;
            arrMhs[1] = mhs2;
            arrMhs[2] = mhs3;

            Console.WriteLine("No. Nim  Nama  Nilai");
            Console.WriteLine("--------------------");
            int i = 1;
            foreach (Mahasiswa mhs in arrMhs)
            {
                Console.WriteLine("{0}  {1} {2}  {3}", i, mhs.nim, mhs.nama, mhs.nilai);
                i++;
            }
            
        }
    }
    class Mahasiswa
    {
        public string nim { get; set; }
        public string nama { get; set; }
        public string nilai { get; set; }
    }
}
