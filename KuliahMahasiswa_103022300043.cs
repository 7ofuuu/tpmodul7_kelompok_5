using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;

namespace tpmodul7_kelompok_5
{
    public class KuliahMahasiswa_103022300043
    {
        public class MataKuliah
        {
            public string code { get; set; }
            public string name { get; set; }
        }

        public class Kuliah
        {
            public List<MataKuliah> course { get; set; }
        }

        public static void ReadJSON()
        {
            string json = File.ReadAllText("C:\\Coding\\Kuliah\\KPL\\tpmodul7_kelompok_5\\tp7_2_103022300043.json");
            Kuliah data = JsonSerializer.Deserialize<Kuliah>(json);

            Console.WriteLine("Daftar mata kuliah yang diambil:");
            int i = 1;
            foreach (var mk in data.course)
            {
                Console.WriteLine($"MK {i} {mk.code} - {mk.name}");
                i++;
            }
        }
    }
}