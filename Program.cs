using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variabel
            bool kunciKetemu = true;   // status pencarian kunci (true = sudah, false = belum)
            int gasMotor = 3;          // tingkat tarikan gas motor untuk pengulangan

            Console.WriteLine("=== TUJUAN: MENJELASKAN LANGKAH-LANGKAH NAIK MOTOR ===");
            Console.WriteLine("Mulai");
            Console.WriteLine("Cari kunci");
            Console.WriteLine("Apakah kunci ketemu?");

            // Percabangan
            if (!kunciKetemu)
            {
                Console.WriteLine("Jika belum, maka tidak melanjutkan mencari kunci.");
                Console.WriteLine("Selesai (Kunci tidak ketemu).");
            }
            else
            {
                Console.WriteLine("Jika sudah, maka lanjut ke langkah berikutnya.");
                Console.WriteLine("Ambil kunci");
                Console.WriteLine("Masuk ke tempat sepeda motor berada");
                Console.WriteLine("Masukkan kunci");
                Console.WriteLine("Stater sepeda motor");
                Console.WriteLine("Tunggangi sepeda motor");

                // Pengulangan (while) untuk langkah ke-9 (gas motor)
                while (gasMotor > 0)
                {
                    Console.WriteLine($"Gas motor (Tarikan ke-{4 - gasMotor})");
                    gasMotor--;
                }

                Console.WriteLine("Selesai");

                Console.WriteLine("   ");

                MieInstant prosesmie = new MieInstant();
                prosesmie.LangkahMembuatMieInstant();
            }
        }
    }
    class MieInstant
    {
        public void LangkahMembuatMieInstant()
        {
            // Variabel
            bool tambahBahan = true;   // status pilihan bahan tambahan (true = ya, false = tidak)
            int adukBumbu = 3;         // jumlah tahapan mengaduk mie dan bumbu

            Console.WriteLine("=== TUJUAN: LANGKAH-LANGKAH MEMBUAT MIE INSTANT GORENG ===");
            Console.WriteLine("Mulai");
            Console.WriteLine("Siapkan mie, bahan, dan alat");
            Console.WriteLine("Didihkan air");
            Console.WriteLine("Masukan mie instant kedalam panci");
            Console.WriteLine("Masukan bahan tambahan atau tidak?");

            // Percabangan
            if (tambahBahan)
            {
                Console.WriteLine("Jika iya, maka masukan ke panci");            
            }
            else
            {
                Console.WriteLine("Jika tidak, maka lanjut ke langkah berikutnya");
            }

            Console.WriteLine("Masukan bumbu ke dalam mangkok");
            Console.WriteLine("Saring mie instant, lalu masukan ke mangkok");

            // Pengulangan
            while (adukBumbu > 0)
            {
                Console.WriteLine($"Aduk mie dan bumbu secara merata (Tahap ke-{4 - adukBumbu})");
                adukBumbu--;
            }

            Console.WriteLine("Selesai");

            Console.WriteLine("   ");

            NyalakanLaptop prosesLaptop = new NyalakanLaptop();
            prosesLaptop.LangkahNyalakanLaptop();
        }
    }
    class NyalakanLaptop
    {
        public void LangkahNyalakanLaptop()
        {
            // Variabel
            bool bateraiCukup = true;  // status daya baterai (true = cukup, false = habis)
            int loading = 3;           // tahapan proses booting/loading sistem

            Console.WriteLine("=== TUJUAN: LANGKAH-LANGKAH MENYALAKAN LAPTOP ===");
            Console.WriteLine("Mulai");
            Console.WriteLine("Ambil laptop dari tas atau tempat penyimpanan");
            Console.WriteLine("Buka penutup (layar) laptop");
            Console.WriteLine("Cek apakah baterai mencukupi?");

            // Percabangan
            if (bateraiCukup)
            {
                Console.WriteLine("Jika ya, maka lanjut tekan tombol power");
            }
            else
            {
                Console.WriteLine("Jika tidak, maka colokkan charger terlebih dahulu");
            }

            Console.WriteLine("Tekan tombol power untuk menyalakan");

            // Pengulangan
            while (loading > 0)
            {
                Console.WriteLine($"Menunggu sistem booting (Proses ke-{4 - loading})");
                loading--;
            }

            Console.WriteLine("Masukkan password atau PIN (jika ada)");
            Console.WriteLine("Selesai");

            Console.WriteLine("   ");

            MencuciPakaian prosesLaptop = new MencuciPakaian();
            prosesLaptop.LangkahMencuciPakaian();
        }   
    }
    class MencuciPakaian
    {
        public void LangkahMencuciPakaian()
        {
            // Variabel
            int waktuTunggu = 3; // tahapan menunggu mesin cuci bekerja

            Console.WriteLine("=== TUJUAN: LANGKAH-LANGKAH MENCUCI PAKAIAN MENGGUNAKAN MESIN CUCI ===");
            Console.WriteLine("Mulai");
            Console.WriteLine("Masukkan pakaian kotor kedalam tabung");
            Console.WriteLine("Masukkan air dan deterjen secukupnya ke dalam wadah mesin cuci");
            Console.WriteLine("Atur tombol waktu dan mode pencucian");
            Console.WriteLine("Tekan tombol start / mulai untuk memulai mencuci pakaian");
            Console.WriteLine("Apakah proses pencucian sudah selesai?");
            Console.WriteLine("   - Jika belum, maka tunggu sampai mesin cuci berhenti otomatis.");

            // Pengulangan (while) untuk proses menunggu mesin cuci sampai selesai
            while (waktuTunggu > 0)
            {
                Console.WriteLine($"   (Menunggu mesin cuci berputar... Tahap ke-{4 - waktuTunggu})");
                waktuTunggu--;
            }

            Console.WriteLine("   - Jika sudah, maka lanjutkan ke langkah berikutnya.");
            Console.WriteLine("Jemur pakaian dibawah sinar matahari");
            Console.WriteLine("Selesai");

            Console.WriteLine("   ");

            PengisianDayaSmartphone prosesLaptop = new PengisianDayaSmartphone();
            prosesLaptop.LangkahPengisianDayaSmartphone();
        }
    }
    class PengisianDayaSmartphone
    {
        public void LangkahPengisianDayaSmartphone()
        {
            // Variabel berdasarkan algoritmamu
            int indikatorPenuh = 3; // tahapan proses menunggu daya baterai penuh

            Console.WriteLine("=== TUJUAN: LANGKAH-LANGKAH PENGISIAN DAYA SMARTPHONE ===");
            Console.WriteLine("Mulai");
            Console.WriteLine("Siapkan charger dan smartphone");
            Console.WriteLine("Hubungkan charger ke stopkontak hingga menancap");
            Console.WriteLine("Sambungkan ujung kabel charger ke port pengisian daya pada smartphone");
            Console.WriteLine("Smart Phone");
            Console.WriteLine("Tunggu hingga indikator pengisian daya penuh");

            // Pengulangan
            while (indikatorPenuh > 0)
            {
                Console.WriteLine($"   (Mengisi daya baterai... Tahap ke-{4 - indikatorPenuh})");
                indikatorPenuh--;
            }

            Console.WriteLine("Smart Phone siap digunakan");
            Console.WriteLine("Selesai");
        }
    }
}