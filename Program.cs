namespace TUGAS_MODUL_3
{

    /* ---[SUPERCLASS PROCESSOR]--- */
    class Processor
    {
        public string merk, tipe;
    }

    /* ---[SUBCLASS DARI PROCESSOR]--- */
    class Intel : Processor
    {
        public Intel()
        {
            base.merk = "Intel";
        }
    }
    class amd : Processor
    {
        public amd()
        {
            base.merk = "AMD";
        }
    }
    /* ---[SUBCLASS DARI CLASS INTEL]--- */

    class CoreI3 : Intel
    {
        public CoreI3()
        {
            base.tipe = "Core i3";
        }
    }
    class CoreI5 : Intel
    {
        public CoreI5()
        {
            base.tipe = "Core i5";
        }
    }
    class CoreI7 : Intel
    {
        public CoreI7()
        {
            base.tipe = "Core i7";
        }
    }

    /* ---[SUBCLASS DARI CLASS AMD]--- */
    class Ryzen : amd
    {
        public Ryzen()
        {
            base.tipe = "RAYZEN";
        }
    }
    class Athlon : amd
    {
        public Athlon()
        {
            base.tipe = "ATHLON";
        }
    }
    /* ---[SUPERCLASS VGA]--- */
    class Vga
    {
        public string merk;
    }
    /* ---[SUBCLASS DARI CLASS VGA]--- */
    class Nvidia : Vga
    {
        public Nvidia()
        {
            base.merk = "Nvidia";
        }
    }
    class AMD : Vga
    {
        public AMD()
        {
            base.merk = "AMD";
        }
    }

    /* ---[SUPERCLASS LAPTOP]--- */
    class Laptop
    {
        public string merk, tipe;
        public Vga vga;
        public Processor processor;

        public void LaptopDinyalakan()
        {
            Console.WriteLine($"Laptop {merk} {tipe} dinyalakan");
        }
        public void LaptopDimatikan()
        {
            Console.WriteLine($"Laptop {merk} {tipe} dimatikan");
        }
    }

    /* ---[SUBCLASS LAPTOP]--- */
    
    /* ---[ASUS]--- */
    class ASUS : Laptop
    {
        public ASUS()
        {
            base.merk = "ASUS";
        }
    }
    /* ---[SUBCLASS DARI CLASS ASUS]--- */
    class ROG : ASUS
    {
        public ROG()
        {
            base.tipe = "ROG";
        }
    }

    class Vivobook : ASUS
    {
        public Vivobook()
        {
            base.tipe = "Vivobook";
        }
        public void Ngoding()
        {
            Console.WriteLine("Ctak Ctak Ctak, error lagi!!");
        }
    }

    /* ---[LENOVO]--- */
    class Lenovo : Laptop
    {
        public Lenovo()
        {
            base.merk = "Lenovo";
        }
    }
    /* ---[SUBCLASS DARI CLASS LENOVO]--- */
    class IdeaPad : Lenovo
    {
        public IdeaPad()
        {
            base.tipe = "IdeaPad";
        }
    }
    class Legion : Lenovo
    {
        public Legion()
        {
            base.tipe = "Legion";
        }
    }

    /* ---[ACER]--- */
    class ACER : Laptop
    {
        public ACER()
        {
            base.merk = "ACER";
        }
    }

    /* ---[SUBCLASS DARI CLASS ACER]--- */
    class Predator : ACER
    {
        public Predator()
        {
            base.tipe = "Predator";
        }
        public void BermainGame()
        {
            Console.WriteLine($"Laptop {merk} {tipe} sedang memainkan game");
        }
    }
    class Swift : ACER
    {
        public Swift()
        {
            base.tipe = "Swift";
        }
    }

    internal class program
    {
        private static Laptop laptop1;
        private static Laptop laptop2;
        private static Predator predator;
        private static ACER acer;

        static void Main(string[] args)
        {
            laptop1 = new Vivobook();
            laptop1.vga = new Nvidia();
            laptop1.processor = new CoreI5();

            laptop2 = new IdeaPad();
            laptop2.vga = new AMD();
            laptop2.processor = new Ryzen();

            predator = new Predator();
            predator.vga = new AMD();
            predator.processor = new CoreI7();

            // SOAL 1
            Console.WriteLine("JAWABAN SOAL 1");
            laptop2.LaptopDinyalakan();
            laptop2.LaptopDimatikan();

            //SOAL 2
            Console.WriteLine("\nJAWABAN SOAL 2");
            //laptop1.Ngoding(); 
            //terjadi error pada program karena method Ngoding() hanya terdapat pada subclass Vivobook dan tidak terdapat pada superclass Laptop.
            //Oleh karena itu akan mengeluarkan pesan error karena tidak dapat menemukan method Ngoding() pada objek laptop1.

            // SOAL 3
            Console.WriteLine("\nJAWABAN SOAL 3");
            Console.WriteLine(laptop1.vga.merk);
            Console.WriteLine(laptop1.processor.merk);
            Console.WriteLine(laptop1.processor.tipe);

            // SOAL 4
            Console.WriteLine("\nJAWABAN SOAL 4");
            predator.BermainGame();

            // SOAL 5
            ACER acer = new Predator();
            // acer.BermainGame();
            // Terdapat error karena variabel acer dideklarasikan sebagai objek dari class ACER dan tidak dapat diisi dengan objek dari subclass Predator

            // SOAL 6
            // Kesimpulan
            // jika mencoba untuk mengakses sebuah method yang tidak ada didalam objek nya maka tidak akan bisa di akses.
            // dan juga jika mendeklarasikan sebuah objek dari sebuah clas maka objek tersebuh objek dari calss tersebh dan tidak dapat diisi dengan objek dari subclass lain.
        }
    }
}