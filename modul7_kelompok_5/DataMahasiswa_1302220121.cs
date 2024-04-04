using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace modul7_kelompok_5
{
    public class DataMahasiswa_1302220121
    {
        public List<Alamat> address { get; set; }
        public List<MataKuliah> courses { get; set; }
        public DataMahasiswa nama {  get; set; }

        public DataMahasiswa_1302220121()
        {
            address = new List<Alamat>();
            courses = new List<MataKuliah>();
        }

        public class Alamat
        {
            public string NamaJalan { get; set; }
            public string Kota { get; set; }
            public string Provinsi { get; set; }
        }

        public class MataKuliah
        {
            public string code { get; set; }
            public string name { get; set; }
        }

        class DataMahasiswa
        {
            public string firstName { get; set; }
            public string lastName { get; set; }
            public string gender { get; set; }
            public string age { get; set; }

        }
        public static void ReadJSON()
        {
            string jsonString = File.ReadAllText("D:\\Praktikum Online\\jurnal7_1_1302220121.json");
            DataMahasiswa_1302220121 mahasiswa = JsonSerializer.Deserialize<DataMahasiswa_1302220121>(jsonString);
            Console.WriteLine("Nama " + mahasiswa.nama.firstName + mahasiswa.nama.lastName);
            Console.WriteLine("Gender: " + mahasiswa.nama.gender);
            Console.WriteLine("Age: " + mahasiswa.nama.age);
        }
    }
}

    
