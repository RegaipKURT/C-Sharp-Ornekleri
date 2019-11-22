using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace thread2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* IsAlive:  Thread çalışıyor mu bilgisini verir.
             * Name:     Thread in adını alır ya da atar.
             * Priority: Thread'ın çalışma önceliğini belirtir.
             * Abort:    Thread abort excepsion hatasını fırlatarak threat çalışmasını iptal eder.
             * Sleep:    Belirtilen süre kadar beklemeye geçer.
             * Suspend:  Thread'i geçiçi süre beklemeye alır, durdurur.
             * Resume:   Beklemeye geçirilmiş thread'in çalışmasının devam etmesini sağlar.             
             */
            Console.WriteLine("Main Thread Started!");
            IsParcacigi isci1 = new IsParcacigi(name:"1. Thread");
            Thread newthread = new Thread(isci1.Run);
            newthread.Start();

            do
            {
                Console.Write(".");
                Thread.Sleep(100);
            } while (isci1.count !=10);


            Console.WriteLine("Main thread has end!");
            Console.ReadLine();

        }
    }
    class IsParcacigi
    {
        public int count;
        public Thread thr;

        public IsParcacigi(string name)
        {
            count = 0;
            thr = new Thread(Run){Name = name};
            thr.Start();
        }
        public void Run()
        {
            Console.WriteLine($"{thr.Name} is starting...");
            do
            {
                Thread.Sleep(100);
                Console.WriteLine($"{thr.Name} is counting {count},");
                count++;

            } while (count <= 10);

            Console.WriteLine($"{thr.Name} finished.");
        }
    }
}
