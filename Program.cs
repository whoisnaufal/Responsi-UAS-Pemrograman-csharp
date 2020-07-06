using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace ProjectProduk
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek produk
        static List<Produk> daftarProduk = new List<Produk>();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";
            bool kondisi = true;

            while (kondisi)
            {
                TampilMenu();

                Console.Write("\nNomor Menu [1..4]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahProduk(daftarProduk);
                        break;

                    case 2:
                        HapusProduk(daftarProduk);
                        break;
                    case 3:
                        TampilProduk(daftarProduk);
                        break;
                    case 4:
                        kondisi = false;
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();
            Console.WriteLine("Pilih Menu Aplikasi");
            Console.WriteLine("\n1. Tambah Produk");
            Console.WriteLine("\n2. Hapus Produk");
            Console.WriteLine("\n3. Tampilkan Produk");
            Console.WriteLine("\n4. Keluar");
        }

        static void TambahProduk(List<Produk> daftarProduk)
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menambahkan produk ke dalam collection
            Produk produk = new Produk();
            Console.WriteLine("Tambah Data Produk\n");
            Console.Write("Kode Produk : ");
            produk.kodeProduk = Console.ReadLine();
            Console.Write("Nama Produk : ");
            produk.namaProduk = Console.ReadLine();
            Console.Write("Harga Beli  : ");
            produk.hargaBeli = Convert.ToDouble(Console.ReadLine());
            Console.Write("Harga Jual : ");
            produk.hargaJual = Convert.ToDouble(Console.ReadLine());

            daftarProduk.Add(produk);
         
            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void HapusProduk(List<Produk> daftarProduk)
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menghapus produk dari dalam collection
            Console.WriteLine("Hapus Data Produk\n");
            string kode;
            bool found = true;
            Console.Write("Kode Produk : ");
            kode = Console.ReadLine();

            for (int i = 0; i < daftarProduk.Count; i++)
            {
                if (daftarProduk[i].kodeProduk == kode)
                {
                    // data jika ditemukan
                    daftarProduk.Remove(daftarProduk[i]);
                    found = true;
                    break;
                }
                else
                {
                    // data jika tdk ditemukan
                    found = false;
                }
            }

            if (!found)
            {
                Console.WriteLine("Kode Produk {0} tidak ditemukan", kode);
            }
            else
            {
                Console.WriteLine("Data produk dengan Kode Produk = {0} berhasil dihapus", kode);
            }
            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilProduk(List<Produk> daftarProduk)
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menampilkan daftar produk yang ada di dalam collection
            Console.WriteLine("Data Produk\n");
            if (daftarProduk.Count > 0)
            {
                for (int i = 0; i < daftarProduk.Count; i++)
                {
                    Console.WriteLine(+(i + 1) + ". " + daftarProduk[i].kodeProduk + ", " + daftarProduk[i].namaProduk + ", " + daftarProduk[i].hargaBeli + ", " + daftarProduk[i].hargaJual);
                }
            }
            else
            {
                Console.WriteLine("Data Produk Kosong");
            }  
            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
