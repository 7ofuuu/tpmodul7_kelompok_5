
// See https://aka.ms/new-console-template for more information
//using System;

//namespace tpmodul07_kelompok_05
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            DataMahasiswa103022300053.ReadJSON();
//        }
//    }
//}

using System;

namespace tpmodul07_kelompok_05

namespace tpmodul7_kelompok_5
﻿using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tpmodul7_kelompok_5;

public class DataMahasiswa103022300064
{
    public class Nama
    {
        public string belakang { get; set; }
        public string depan { get; set; }
    }
    public class Mahasiswa
    {
        public Nama nama { get; set; }
        public long nim { get; set; }
        public string fakultas { get; set; }
    }

    public static void readJSON()
    {
        string jsonString = File.ReadAllText("D:\\My Code\\GUI C#\\KELOMPOK\\TUGAS KELOMPOK\\tpmodul7_kelompok_5\\tp7_1_103022300064.json");
        Mahasiswa? mahasiswa = JsonSerializer.Deserialize<Mahasiswa>(jsonString);
        if (mahasiswa != null)
        {
            Console.WriteLine($"Nama {mahasiswa.nama.depan} {mahasiswa.nama.belakang} dengan nim {mahasiswa.nim} dari fakultas {mahasiswa.fakultas}");
        }
        else
        {
            Console.WriteLine("Gagal melakukan deserialisasi JSON.");
        }
    }
}

public class KuliahMahasiswa103022300064
{
    public class Course
    {
        public string code { get; set; }
        public string name { get; set; }
    }

    public class CourseList
    {
        public List<Course> courses { get; set; }
    }

    public static void readJSON()
    {
        string path = "D:\\My Code\\GUI C#\\KELOMPOK\\TUGAS KELOMPOK\\tpmodul7_kelompok_5\\tp7_1_103022300064.json";
        string jsonString = File.ReadAllText(path);
        CourseList? data = JsonSerializer.Deserialize<CourseList>(jsonString);

        if (data != null && data.courses != null)
        {
            Console.WriteLine("Daftar mata kuliah yang diambil:");
            int index = 1;
            foreach (var course in data.courses)
            {
                Console.WriteLine($"MK {index} {course.code} - {course.name}");
                index++;
            }
        }
        else
        {
            Console.WriteLine("Gagal melakukan deserialisasi JSON.");
        }
    }
}


{
    class Program
    {
        static void Main(string[] args)
        {

            KuliahMahasiswa103022300053.ReadJSON();
        }
    }
}


            DataMahasiswa103022330117.ReadJSON();
            KuliahMahasiswa103022330117.ReadJSON();

            DataMahasiswa_103022300043.ReadJSON();
            Console.WriteLine();
            KuliahMahasiswa_103022300043.ReadJSON();

            DataMahasiswa103022300064.readJSON();
            KuliahMahasiswa103022300064.readJSON();

        }
    }
}

