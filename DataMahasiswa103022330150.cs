using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace tpmodul7_kelompok_5
{
    class DataMahasiswa103022330150
    {
        public class Nama
        {
            public string depan { get; set; }
            public string belakang { get; set; }
        }

        public class Mahasiswa
        {
            public Nama nama { get; set; }
            public long nim { get; set; }
            public string fakultas { get; set; }
        }

        public void ReadJSON()
        {
            string filePath = "C:/Konstruksi PL/tpmodul7/tpmodul7_kelompok_5/tp7_1_103022330150.json";

            try
            {
                string jsonString = File.ReadAllText(filePath);
                Mahasiswa mahasiswa = JsonSerializer.Deserialize<Mahasiswa>(jsonString);
                Console.WriteLine($"Nama {mahasiswa.nama.depan} " +
                    $"{mahasiswa.nama.belakang} " +
                    $"dengan nim {mahasiswa.nim} dari fakultas {mahasiswa.fakultas}");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File JSON tidak ditemukan");
            }
            catch (JsonException)
            {
                Console.WriteLine("Format JSON tidak valid");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
