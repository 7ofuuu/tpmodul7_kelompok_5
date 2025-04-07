using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;
using tpmodul7_kelompok_5;


namespace tpmodul7_kelompok_5
{
    class Program
    {
        static void Main(string[] args)
        {
            DataMahasiswa_103022300043.ReadJSON();
            Console.WriteLine();
            KuliahMahasiswa_103022300043.ReadJSON();
        }
    }
}