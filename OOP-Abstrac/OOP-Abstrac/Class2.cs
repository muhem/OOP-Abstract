using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Abstrac
{
    class Implementasi : Abstract
    {
        public override void ShowKTP(string nama, string almt)
        {
            Console.WriteLine("KTP(Kartu Tanda Penduduk)");
            Console.WriteLine();
            Console.WriteLine("Nama      : {0}", nama);
            Console.WriteLine("Alamat    : {0}", almt);
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}