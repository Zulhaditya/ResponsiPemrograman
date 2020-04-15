using System;

namespace ResponsiPemrograman2893
{
    class Program
    {
        static void Main(string[] args)
        {



            Karyawan karyawan1 = new Karyawan(19112893, "Zulhaditya", 500000);
            Karyawan karyawan2 = new Karyawan(19012271, "Delanno", 300000);


            Console.WriteLine("NIK \t Nama \t Gaji");
            Console.WriteLine("--------------------------");
            karyawan1.showKaryawan();
            karyawan2.showKaryawan();

            Console.WriteLine("\n\n Alhamdulillah naik gaji nih 10%");

            Console.WriteLine("NIK \t Nama \t Gaji");
            Console.WriteLine("--------------------------");
            karyawan1.naikGaji();
            karyawan2.naikGaji();

            Console.ReadKey();
        }
    }

    class Karyawan
    {
        public int nik { get; set; }
        public string nama { get; set; }
        public int gajiBulanan { get; set; }

        public Karyawan(int nik, string nama, int gaji)
        {
            this.nik = nik;
            this.nama = nama;

            if(gaji < 0)
            {
                this.gajiBulanan = 0;
            } else
            {
                this.gajiBulanan = gaji;
            }
        }

        public void showKaryawan()
        {
            Console.WriteLine("{0} \t {1} \t {2}", nik, nama, gajiBulanan);
        }

        public void naikGaji()
        {
            double tmp = 0;
            tmp =  0.1 * gajiBulanan;
            gajiBulanan += Convert.ToInt32(tmp);
            Console.WriteLine("{0} \t {1} \t {2}", nik, nama, gajiBulanan);
        }
    }
}