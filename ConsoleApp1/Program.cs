using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program:IKullanıcı
    {
        public string Ad { get; set; }
        public string Email { get; set; }
        public string Sifre { get; set; }
        static void Main(string[] args)
        {
            IKullanıcı inf = new IKullanıcı();
            inf.("s","d","a");
            
        }

        public void KullanıcıEkle(string ad, string email, string şifre)
        {
            Console.WriteLine($"Kullanıcı Eklendi.\t Ad: {ad}, E-mail: {email}");
        }
        
        public void KullanıcıGoster(int KullıcıId)
        {
            throw new NotImplementedException();
        }

        public void KullanıcıSil(int KullanıcıId)
        {
            throw new NotImplementedException();
        }
    }
}
