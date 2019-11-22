using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace reflection2
{
    class Program
    {
        static void Main()
        {

            //var user = new User { UserId = 12, Username="Yeni Kullanıcı", Email="abc@gmail.com"};

            //var props = user.GetType().GetProperties();

            //foreach (var pr in props)
            //{
            //    Console.WriteLine(pr.Name);
            //}
            //Console.WriteLine("----------------------");
            //var prop1 = user.GetType().GetProperty("Username");
            //Console.WriteLine(prop1.Name);
            //Console.WriteLine(prop1.GetValue(user));

            //User metodunun içini okuyalım
            Type t = typeof(User);
            User reflect = new User(10,20);
            MethodInfo[] mi = t.GetMethods();
            int val;
            double fark;
            //Console.Write("Method Adı: {0},   ", t.Name);
            //Console.WriteLine("\n\nİncelenen Metotlar: ");

            //foreach (MethodInfo m in mi)
            //{
            //    ParameterInfo[] pi = m.GetParameters();
            //    Console.Write("İsim: " + m.Name + ",\nParametreler: ");
            //    foreach (var i in  m.GetParameters())
            //    {
            //        for (int j = 0; j < pi.Length; j++)
            //        {
            //            Console.Write(i.ParameterType.Name + " " + pi[j].Name.ToString() + "  ");
            //        }

            //    }
            //    Console.WriteLine();
            //}

            foreach (MethodInfo m in mi)
            {
                ParameterInfo[] pi = m.GetParameters();
                if (m.Name.Equals("Set", StringComparison.OrdinalIgnoreCase) && pi[0].ParameterType==typeof(int))
                {
                    object[] args = new object[2];
                    args[0] = 9;
                    args[1] = 18;
                    m.Invoke(reflect, args);

                }


                else if (m.Name.Equals("cıkar", StringComparison.Ordinal) && pi[0].ParameterType == typeof(double))
                {
                    object[] args = new object[2];
                    args[0] = 9;
                    args[1] = 18;
                    fark = (double)m.Invoke(reflect, args);
                    Console.WriteLine("Fark = " + fark);


                }
                else if (m.Name.Equals("topla", StringComparison.Ordinal))
                {
                    object[] args = new object[2];
                    args[0] = 9;
                    args[1] = 18;

                    val = (int)m.Invoke(reflect, args);
                    Console.WriteLine("Toplam = " + val);
                }

            }
            
            Console.ReadLine();
        }
    }

    public class User {
        int a, b;
        public User(int a, int b) { }
        public int UserId { get; set; }
        public string Username  { get; set; }
        public string Email { get; set; }
        public double cıkar(double a, double b) { return a - b; }
        public void set(int a, int b) { this.a = a; this.b = b; Console.WriteLine("ÇARPIM: " + a*b); }
        public int topla(int a, int b) { return a + b; }


    }
}
