using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace tpmodul7_kelompok_5
{
    public class KuliahMahasiswa103022330150
    {
        public class Course
        {
            public string code { get; set; }
            public string name { get; set; }
        }

        public class CourseList
        {
            public Course[] courses { get; set; }
        }

        public void ReadJSON()
        {
            string filePath = "C:/Konstruksi PL/tpmodul7/tpmodul7_kelompok_5/tp7_2_103022330150.json";

            try
            {
                string jsonString = File.ReadAllText(filePath);
                CourseList courseList = JsonSerializer.Deserialize<CourseList>(jsonString);
                Console.WriteLine("Daftar mata kuliah yang diambil:");

                for (int i = 0; i < courseList.courses.Length; i++)
                {
                    Console.WriteLine($"MK {i + 1} {courseList.courses[i].code} - {courseList.courses[i].name}");
                }
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
