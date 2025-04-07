using System;
using System.IO;
using System.Text.Json;

namespace tpmodul7_kelompok_5
{
    public class DataMahasiswa_103022300043
    {
        public class Mahasiswa
        {
            public Nama nama { get; set; }
            public long nim { get; set; }
            public string fakultas { get; set; }
        }

        public class Nama
        {
            public string depan { get; set; }
            public string belakang { get; set; }
        }

        public static void ReadJSON()
        {
            string json = File.ReadAllText("C:\\Coding\\Kuliah\\KPL\\tpmodul7_kelompok_5\\tp7_1_103022300043.json");
            Mahasiswa mhs = JsonSerializer.Deserialize<Mahasiswa>(json);
            Console.WriteLine($"Nama {mhs.nama.depan} {mhs.nama.belakang} dengan nim {mhs.nim} dari fakultas {mhs.fakultas}");

        }
    }

    
}
