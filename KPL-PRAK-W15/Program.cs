// See https://aka.ms/new-console-template for more information
// Console.WriteLine


// Console.WriteLine("Hello, World!");
using Modul15.LoginRegist;

namespace MODUL05_1302220093
{
    
    // Memanggil Class dengan nama SimpleDataBase dengan generic T
    public class SimpleDataBase<T>
    {
        // Mendeklarasi data-data pada tabel SimpleDataBase
        List<T> storedData;
        List<DateTime> inputDates;

        // Constructor untuk SimpleDataBase agar list storedData dan list inputDates kosong
        public SimpleDataBase()
        {
            this.storedData = new List<T>();
            this.inputDates = new List<DateTime>();
        }

        // Method untuk menerima dan memasukkan data ke dalam list
        public void AddNewData(T iniData)
        {
            this.storedData.Add(iniData);
            this.inputDates.Add(DateTime.Now);
        }

        // Untuk menampilkan 3 data 2 digit nim pada console sebanyak yang terdapat pada list
        public void PrintAllData()
        {
            for (int i = 0; i < storedData.Count; i++)
            {
                Console.WriteLine("Data " + (i+1) + " berisi : " + storedData[i] + ", yang disimpan pada waktu UTC: " + inputDates[i]);
            }
        }
    }

    // Class dengan nama Penjumlahan
    public class Penjumlahan
    {
        // Membuat Method dengan Generic Method T dan parameter T yang sama sebanyak 3 kali
        public void JumlahTigaAngka<T>(T inp1, T inp2, T inp3)
        {
            // deklarasi 3 variabel dengan tipe data dynamic untuk menampung inputan 
            dynamic a = inp1;
            dynamic b = inp2;
            dynamic c = inp3;

            // mengubah penjumlahannya menjadi double dan menampilkan pada console
            double Hasil = a +  b + c;
            Console.WriteLine("Hasil : " + Hasil);
        }

        // Method Utama Untuk Run
        public static void Main(string[] args)
        {
            bool cekSign = false;
            string userName = Console.ReadLine();
            string password = Console.ReadLine();

            Sign sign = new Sign();
            sign.Registration(userName, password);

            while (cekSign == false)
            {
                cekSign = sign.Login(userName, password);
            }

            // Method atau Object untuk melakukan run class Penjumlahan
            Penjumlahan soal3 = new Penjumlahan();
            Console.WriteLine("Masukkan 3 Angka : ");
            double ang1 = float.Parse(Console.ReadLine());
            double ang2 = float.Parse(Console.ReadLine());
            double ang3 = float.Parse(Console.ReadLine());
            soal3.JumlahTigaAngka(ang1, ang2, ang3);
            Console.WriteLine(" ");

            // Method atau object untuk eksekusi Class SimpleDataBase
            SimpleDataBase<double >DB=new SimpleDataBase<double>();
            DB.AddNewData(ang1);
            DB.AddNewData(ang2);
            DB.AddNewData(ang3);
            DB.PrintAllData();
        }
    }
}