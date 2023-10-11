//stuktur umum program c#
//1.Deklarasi Pustaka
using System;
using System.Data;
using System.Globalization;
using System.Numerics;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;

namespace TUGAS
{   //2. bagian class
    class Program
    {   //3. bagian fungsi
        public static void Main(string[] args)
        {
            Console.WriteLine("HelloWorld");//tanpa variable
            //variable
            /*string DivisiDNCC;
            DivisiDNCC="game";
            Console.WriteLine(DivisiDNCC);*/
            //Deklarasi variable
            /*string DivisiDNCC="game";
            Console.WriteLine(DivisiDNCC);*/
            //kata kunci var
            /*var DivisiDNCC="game";
            Console.WriteLine(DivisiDNCC);*/
            
            
            //const
            //digunakan untuk menjadikan variable dan nilainya menjadi immutable (tidak bisa diubah sama sekali)
            /*const float phi = 3.14f;
            Console.WriteLine(phi);*/


            //ini adalah komentar single line
            /*
            yang ini multi line
            */
            
            //Tipe data number
            /*int angka = 10;
            double angkadouble =25.16;
            float angakfloat = 232.3554f;
            Console.WriteLine(angka);
            Console.WriteLine(angkadouble);
            Console.WriteLine(angakfloat);*/
            
            
            //string
            /*string firstname = "DNCC";
            string lastname = "Game";
            Console.WriteLine(firstname);
            Console.WriteLine(lastname);
            firstname+=lastname;
            Console.WriteLine(firstname);*/


            
            //karakter backslash (\t membuat kolom,\r membuat baris,\" membuat tanda kutip)
            /*string bloon = "BAD \tZOMG \tMOAB \tDDT \tBFB";
            string monkey = "Dart_monkey \rBoomerang_monkey \rTack_shooter \rTrue_sun_god_support_Temple ";
            string powerup = "\"Thrive\" \"Super_monkey_storm\" \"Time_stop\" \"Pontoon\" \"MOAB_mine\"";
            Console.WriteLine(bloon);
            Console.WriteLine(monkey);
            Console.WriteLine(powerup);*/
            

            //string manipulation
            /*string txt = "SONO CHI NO SA DAME";
            string txtupper = txt.ToUpper();
            string txtlower = txt.ToLower();
            Console.WriteLine(txtupper);
            Console.WriteLine(txtlower);
            Console.WriteLine("panjang karakter dari txt adalah: " + txt.Length);*/

            //string interpolation
            /*string nama = "Handy Wibowo Wahyunudin";
            var date = DateTime.Now;
            Console.WriteLine($"Perkenalkan nama saya {nama}, hari ini adalah {date.DayOfWeek} jam {date:HH:MM:SS}");*/



            //boolean
            //Tipe data boolean dalam bahasa pemrograman C# digunakan untuk merepresentasikan dua nilai yang mungkin: true (benar) atau false (salah).
            //tipe data ini sangat penting dalam logika pemrograman karena digunakan untuk mengontrol alur eksekusi program dan membuat keputusan berdasarkan kondisi tertentu.
            //Tipe data boolean juga sering digunakan dalam ekspresi logika seperti && (dan), || (atau), dan ! (negasi) untuk membuat ekspresi yang lebih kompleks untuk pengambilan keputusan dalam program.
            /*bool benar = true;
            bool salah = false;
            if(benar == false){
                Console.WriteLine("ini adalah pernyataan benar");
            }else{
                Console.WriteLine("ini adalah pernyataan salah");
            }*/


            //number to string
            /*int angkatostring = 99;
            Console.WriteLine($"DDD {angkatostring.ToString()}");*/


            //string ke int
            /*string pertama = "142";
            string kedua = "524";
            int sum = int.Parse(pertama) + int.Parse(kedua);
             Console.WriteLine(sum);*/



            //Operator Aritmatika
            // + penjumlahan
            // - pengurangan
            // * perkalian
            // / pembagian
            // % modulo(sisa hasil bagi)
            /*var result1 = 40 + 30;
            var result2 = 50 - 30;
            var result3 = -434;
            var result4 = 50 * 80;
            var result5 = 50 / 3;
            var result6 = 760 % 100;
            Console.WriteLine(result1);
            Console.WriteLine(result2);
            Console.WriteLine(result3);
            Console.WriteLine(result4);
            Console.WriteLine(result5);
            Console.WriteLine(result6);*/

            
            
            
            //Increment dan Decrement
            //++a = Hasil dari ++a adalah nilai a setelah operasi
            //a++ = Hasil dari a++ adalah nilai a sebelum operasi
            //-a = Hasil dari –a adalah nilai a setelah operasi
            //a- = Hasil dari a–  adalah nilai a sebelum operasi
            /*int a=10;
            Console.WriteLine(a);
            Console.WriteLine(++a);
            Console.WriteLine(a);
            int b=10;
            Console.WriteLine(b);
            Console.WriteLine(b++);
            Console.WriteLine(b);
            int c=10;
            Console.WriteLine(c);
            Console.WriteLine(--c);
            Console.WriteLine(c);
            int d=10;
            Console.WriteLine(d);
            Console.WriteLine(d++);
            Console.WriteLine(d);*/

            // Operator Perbandingan
            // == : Sama Dengan
            //  > : Lebih Dari
            //  < : Kurang Dari
            // >= : Lebih Dari atau Sama Dengan
            // <= : Kurang Dari atau Sama Dengan

            // Operator Logika
            // && : Dan
            // || : Atau
            //  ! : Kebalikan
            

            //Array
            //Array dalam C# digunakan untuk menyimpan koleksi elemen dengan tipe data yang sama dalam urutan terindeks.
            //Indeks array dimulai dari 0, yang berarti elemen pertama memiliki indeks 0, elemen kedua memiliki indeks 1, dan seterusnya.
            //Array dapat memiliki dimensi tunggal, 2 dimensi, dan multidimensi yang lain.
            /*string[] Monkey = {"Dart_monkey", "Boomerang_monkey", "Tack_shooter", "True_sun_god_support_Temple", "Sauda", "Sniper_monkey"};
            Console.WriteLine(Monkey[0]);
            Console.WriteLine(Monkey[1]);
            Console.WriteLine(Monkey[2]);
            Console.WriteLine(Monkey[3]);
            Console.WriteLine(Monkey[4]);
            Console.WriteLine(Monkey[5]);
            string[] names = new string [6];
            names [0] = "Dart_monkey";
            names [0] = "Boomerang_monkey";
            names [0] = "Tack_shooter";
            names [0] = "True_sun_god_support_Temple";
            names [0] = "Sauda";
            names [0] = "Sniper_monkey";*/

            //array 2D
            /*int[,] x= new int[4,5];
            int[,] xs={{1,2,3,4,5,6,7,8},{9,10,11,12,13,14,15,16}};
            Console.WriteLine(xs[0,1]); //2
            Console.WriteLine(xs[1,3]); //12 */

            //array 3D
            /*int[,,] x= new int [1,2,3];
            int[,,] xs= {{{1,2,3,4,5,6},{7,8,9,10,11,12}},{{13,14,15,16,17,18},{19,20,21,22,23,24}}};
            Console.WriteLine(xs[1,0,2]); //15
            Console.WriteLine(xs[0,0,3]); //4
            Console.WriteLine(xs[0,0,1]); //2
            Console.WriteLine(xs[0,1,3]); //10*/

            //list
            //List dalam C# adalah salah satu struktur data yang sangat berguna dan fleksibel yang digunakan untuk menyimpan kumpulan elemen atau objek dalam urutan tertentu.
            //List memungkinkan Anda untuk menambahkan, menghapus, atau mengakses elemen-elemen di dalamnya dengan mudah.
            /*List<int> angka= new List<int>();
            angka.Add(1);
            angka.Add(2);
            angka.Add(3);
            angka.AddRange(new int[6] {4,5,6,7,8,9});
            angka.Remove(0);
            angka.RemoveAt(0);
            angka.IndexOf(2);
            Console.WriteLine(angka.Contains(5));
            Console.WriteLine(angka.Count());
            foreach(var a in angka)
            Console.Write(a+" ");*/




            //Pengkondisian If else
            //if-else adalah salah satu pengendalian alur program yang digunakan untuk mengambil keputusan berdasarkan kondisi tertentu. Ini memungkinkan program untuk menjalankan blok kode tertentu jika kondisi tertentu terpenuhi, dan menjalankan blok kode lain jika kondisi tersebut tidak terpenuhi.
            //if Statement: Blok kode dalam if statement akan dijalankan jika kondisi yang diuji adalah benar (true).
            //else Statement: Blok kode dalam else statement akan dijalankan jika kondisi yang diuji dalam if adalah salah (false).
            //else if Statement: untuk menguji beberapa kondisi secara berurutan. Blok kode dalam else if statement akan dijalankan jika kondisi yang diuji dalam if sebelumnya adalah salah (false), dan kondisi dalam else if adalah benar (true).
            /*int x =90;
            if (x>=85)
            {
                Console.WriteLine("a");
            }
            if (x>=80)
            {
                Console.WriteLine("b");
            }
            if (x>=60)
            {
                Console.WriteLine("c");
            }
            else
            {
                Console.WriteLine("e");
            }*/

            
            
            //pengkondisian switch
            //switch adalah salah satu struktur kontrol yang digunakan dalam pemrograman untuk membuat keputusan berdasarkan nilai ekspresi yang berbeda.
            /*int x=90;
            switch(x)
            {
                case > 90:
                    Console.WriteLine("A");
                    break;
                 case > 80:
                    Console.WriteLine("b");
                    break;
                case > 70:
                    Console.WriteLine("c");
                    break;
                case >= 50:
                    Console.WriteLine("e");
                    break;
            }*/

            //ternary operator
            //Operator ternary adalah cara singkat untuk mengevaluasi ekspresi berdasarkan kondisi tertentu. operasi ini mirip seperti dengan if else namun lebih singkat
            /*int x=40;
            string y=(x%2==0)?"genap":"ganjil";
            Console.WriteLine(y);*/

            //perulangan
            //Perulangan atau looping adalah konsep yang sangat penting dalam pemrograman yang digunakan untuk mengulangi serangkaian perintah atau tugas tertentu berulang kali selama kondisi tertentu terpenuhi. 
            //Dengan menggunakan perulangan, Anda dapat mengeksekusi blok kode yang sama berulang kali tanpa harus menulisnya secara berulang.
            //Ada beberapa jenis perulangan yang umum digunakan dalam C#, For,while, do while, foreach

            //perulangan for
            /*for (int i=2; i<20;i++)
            {
                Console.WriteLine("tes ke "+i);
            }*/

            
            //perulangan while
            /*int x=7;
            while (x<30);
            {
                Console.WriteLine("tes ke "+x);
                x++;
            }*/

            
            //perulangan do while
            /*int x=7;
            do
            {
                Console.WriteLine("ppp ke "+x);
                x++;
            }
            while (x<30);
            {
                Console.WriteLine("tes ke "+x);
                x++;
            }*/

            //perulangan foreach
            /*int x=0;
            int [] y= new int[8] {1,2,3,4,5,6,7,8};
            foreach (int a in y)
            {
                Console.WriteLine("isi array urut dari indeks "+ x++ + " yaitu "+ a);
            }*/

        
        
        
        //break
        //Break adalah pernyataan yang biasanya digunakan dalam loop (for, while, atau do-while) atau dalam struktur switch untuk menghentikan eksekusi loop atau keluar dari struktur switch lebih awal. 
        /*for (int x=3;x<15;x++)
        {
            Console.WriteLine("tes ke "+x);
            if (x==10)
            {
                break;
            }
        }*/

        
        
        //continue
        //Continue adalah pernyataan yang digunakan dalam loop untuk melanjutkan ke iterasi berikutnya tanpa menjalankan kode di bawahnya dalam iterasi saat ini.
        /*for (int x=0;x<15;x++)
        {
            if (x%2==0)
            {
                continue;
            }
            Console.WriteLine(x);
        }*/


        }
    }
}
