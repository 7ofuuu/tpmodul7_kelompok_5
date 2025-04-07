using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;

namespace TP7
{
    public class Mahasiswa
    {
        public string nama_depan { get; set; }
        public string nama_belakang { get; set; }
        public string nim { get; set; }
        public string fakultas { get; set; }
    }

    public class MataKuliah
    {
        public string kode { get; set; }
        public string nama { get; set; }
    }

    public class Kuliah
    {
        public List<MataKuliah> matkul { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string json1 = File.ReadAllText("tp7_1_103022300079.json");
            var mhs = JsonSerializer.Deserialize<Mahasiswa>(json1);
            Console.WriteLine($"Nama {mhs.nama_depan} {mhs.nama_belakang} dengan nim {mhs.nim} dari fakultas {mhs.fakultas}");

            string json2 = File.ReadAllText("tp7_2_103022300079.json");
            var kuliah = JsonSerializer.Deserialize<Kuliah>(json2);
            Console.WriteLine("Daftar mata kuliah yang diambil:");
            int i = 1;
            foreach (var mk in kuliah.matkul)
            {
                Console.WriteLine($"MK {i++} {mk.kode} - {mk.nama}");
            }
        }
    }
}
