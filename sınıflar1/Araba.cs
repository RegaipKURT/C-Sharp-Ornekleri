using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sınıflar1
{
    class Araba
    {
        // FIELD - CLASS ALANI 
        // Bunların hepsi normalde private olmalı ve property (gettter - setter) ile düzenlenebilmeli
        private string renk;
        private int vites;
        private int hız;
        private string uretici;
        private double motor_hacmi;
        private string seri_no; //Hiç bir şey yazılmazsa default private olarak tanımlanır.


        //ERİŞİM BELİRLEYİCİLERİ
        /* Public: Her yerden erişilebilir.
         
         * Private: Sadece tanımlandığı sınıfın içinden erişilebilir.
         
         * Internal: Sadece bulunduğu projede erişilebilir.
         
         * Protected: Sadece tanımlandığı sınıf veya o sınıfı miras alan sınıflardan erişilebilir.
                      Aynı projede olma şartı yoktur.

         * Protected Internal: Aynı proje içinde olmak şartıyla, tanımlandığı sınıf veya o sınıfı miras alan
                               sınıflar içinden erişilebilir.
           
           Belirtilmemişse default olarak private tanımlama yapılır!
         */


        //CONSTRUCTOR METHOD 
        // EĞER YOKSA OTOMATİK OLUŞTURULUR. BİZ YAPARSAK SINIFIN ADIYLA AYNI OLMAK ZORUNDA!
        // Eğer sadece parametreli bir constructor yazarsak, artık parametresiz kullanamayız.
        // CONSTRUCTOR METHODLARDA GERİ DÖNÜŞ TİPİ YOKTUR!
        public Araba() // bu bir yapıcı metottur.
        {
            seri_no = Convert.ToString(Guid.NewGuid());
            Console.WriteLine("Araba Sınıfından Nesne Oluşturuldu!\n");
        }

        //CONSTRUCTOR OVERLOAD
        public Araba(string renk = "Siyah", int vites = 6, double motor_hacmi = 2.4, string uretici = "Unknown",
            int hız = 250)
        {
            this.Renk = renk; // buradaki renk dışardan gelen parametre, this.renk ise sınıfın özelliği
            this.Vites = vites;
            this.motor_hacmi = motor_hacmi;
            this.Hız = hız;
            this.uretici = uretici;
            seri_no = Convert.ToString(Guid.NewGuid()); //eşşiz id oluşturur.(Globally Unique Identifier)
        }

        // DESTRUCTOR METHOD -- YIKICI METOT
        // UYGULAMA KAPANIRKEN GARBAGE COLLECTOR VEYA ÇÖP TOPLAMA MEKANİZMASI ÇALIŞIR.
        // YANİ UYGULAMA KAPANDIĞINDA NESNE HAFIZADAN SİLİNİR.
        // BU SİLİNME VEYA ÇÖP TOPLAMA MEKANİZMASI SIRASINDA MÜDAHALE ETMEK İSTERSEK DESTRUCTOR KULLANIRIZ.

        ~Araba() // destructor sınıf adının başına ~ işareti konularak oluşturulur. 
        {
            Console.WriteLine("Sınıf yıkılıyor!!!");
            System.Threading.Thread.Sleep(2000);
        }

        // GETTER & SETTER METHODS veya ENCAPSULATION (KAPSÜLLEME)
        /* getter ve setter metotlar otomatik yazıldıktan sonra değerlerin dışarıya açık olmasına gerek yoktur.
         * çünkü iki defa dışardan . koyulup ulaşıldığında iki defa görünecektir.
         * ayrıca güvenlik sağlayacağı için de private olması iyi olacaktır.
         */
        public double GetMotorHacmi()
        {
            return motor_hacmi;
        }
        public void SetMotorHacmi(double motor_hacmi)
        {
            if (motor_hacmi >= 1.6)
            {
                this.motor_hacmi = motor_hacmi;

            }
            else
            {
                this.motor_hacmi = 1.6;
            }
        }

        // GETTER VE SETTER METODLARIN OTOMATİK OLUŞTURULMASI
        protected internal string Uretici
        {
            get { return uretici; }
            set{ uretici = value; }
        }
        // eğer bir özelliğin dışardan değişmesini istemiyorsak private yaparız ve
        // kapsülleme yaparken set metodu koymayız. böylece değere ulaşılabilir ama değiştirilemez.
        // örneğin
        public string SeriNo //setter olmadığı için seri_o değiştirilemez.
        {
            get { return seri_no; }
        }

        //!!! değer oluşturunca CTRL+. VEYA ALT+ENTER YAPARSAK OTOMATİK PROPERTY (GETTER -SETTER) OLUŞTURUR.
        // AŞAĞIDAKİLER OTOMATİK OLARAK OLUŞTURULDU!
        public string Renk { get => renk; set => renk = value; }
        public int Vites { get => vites; set => vites = value; }
        public int Hız { get => hız; set => hız = value; }
    }
}
