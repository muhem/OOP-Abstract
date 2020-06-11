using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

abstract class Abstract
{
    public abstract void ShowKTP(string nama, string almt);
    public void ShowMHS(string nama, string nim, string jur)
    {
        Console.WriteLine("KTM (Kartu Tanda Mahasiswa)");
        Console.WriteLine();
        Console.WriteLine("Nama      : {0}", nama);
        Console.WriteLine("NIM       : {0}", nim);
        Console.WriteLine("Jurusan   : {0}", jur);
        Console.WriteLine();
    }
}