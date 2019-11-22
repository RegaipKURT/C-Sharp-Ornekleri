using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace extension_methods
{
    public static class MyExtensions
    {
        public static void DisAssembly(this object obj)
        {
            Console.WriteLine("Object Type: {0}, Assembly: \n{1}", obj.GetType().Name,
                Assembly.GetAssembly(obj.GetType()).GetName().Name);
        }


        /// <summary>
        /// Projedeki her int sayi tipi için karesini alma metodu
        /// int sayi alır ve karesini int olarak döndürür.
        /// </summary>
        /// <param name="sayi"></param>
        /// <returns></returns>
        public static int Kare(this int sayi)
        {
            return sayi * sayi;
        }

        public static void TersCevirGoster(this string kelime)
        {
            List<char> yeni = new List<char>();
            int a = 1;

            while (a <= kelime.Length)
            {
                yeni.Add(kelime[kelime.Length - a]);
                ++a;
            }

            yeni.ForEach(i =>Console.Write(i));
            Console.WriteLine();
        }
        public static string TersCevirAl(this string kelime)
        {
            string yeni="";
            int a = 0;

            while (a <= kelime.Length - 1)
            {
                yeni = yeni.Insert(a, kelime[kelime.Length - a - 1].ToString());
                ++a;
            }
            return yeni;
        }

        public static void ShowItems(this System.Collections.IEnumerable iterable)
        {
            foreach (var item in iterable)
            {
                Console.Write(" " + item.ToString());
            }
        }
    }
}
