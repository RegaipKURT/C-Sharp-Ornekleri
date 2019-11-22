using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace task_parallel_library
{
    class Program
    {
        static void Main(string[] args)
        {
            ///*
            // * TPL- TASK PARALLEL LİBRARY
            // * Thread işlemcide işlemleri sıraya sokar ve hızlı geçişlerle yapar.
            // * Birden fazla işlemci varsa task ile gerçekten birden çok işlem aynı anda yapılabilir.
            // * görev başlatmak, durdurmak, devam etmek, bir görevin kaldığı yerden diğerinin devam etmesi gibi 
            // * durumlar söz konusu olabilir. 
            // * 
            // * NOT: EĞER GERÇEKTEN ÇOK İŞLEMCİLİ BİR BİLGİSAYARINIZ YOKSA BU PROGRAM KODU YAZDIĞIMIZ
            // * SIRAYLA ÇALIŞACAKTIR! ÇÜNKÜ TASK GERÇEKTEN BİRDEN FAZLA İŞLEMİ AYNI ANDA YAPAR. AMA BİLGİSAYARIN 
            // * BUNU YAPABİLMESİ İÇİN YA ÇOK ÇEKİRDEKLİ(TAKLİT ETMEYEN TÜRDEN) OLMASI YA DA BİRDEN FAZLA İŞLEMCİ 
            // * OLMASI GEREKECEKTİR. 
            // */

            //Console.WriteLine("Main thread başladı.");
            //Task tsk = Task.Factory.StartNew(()=> { Console.WriteLine("Yeni Görev Başladı!");
            //    for (int i = 0; i < 10; i++)
            //    {
            //        System.Threading.Thread.Sleep(500);
            //        Console.WriteLine("Task is counting {0}", i);
            //    }
            //});

            //Console.WriteLine("Durum: {0}", tsk.Status.ToString());
            //tsk.Wait();

            //Console.WriteLine("Durum: {0}", tsk.Status.ToString());
            //tsk.Dispose(); // task yok edildi!
            //Console.WriteLine("Main Thread Bitti!");

            //Task tsk = new Task(MyTask);
            //Thread t = Thread.CurrentThread;

            //Console.WriteLine("Main Thread Id: {0}\nTask Id: {1}", t.ManagedThreadId, tsk.Id);

            //tsk.Start();

            //for (int i = 0; i < 60; i++)
            //{
            //    Thread.Sleep(100);
            //    Console.Write(".");
            //}

            //tsk.Wait(200);

            //Console.WriteLine("Main Thread Bitti!");


            // DEVAM TASKLERİ - BİR TASK ARDINDAN OTOMATİK DEVAM EDEN TASK
            //Task tsk = new Task(MyTask);
            //Task ConTask = tsk.ContinueWith(ContinuitaonTask);

            //tsk.Start();

            //Console.WriteLine("Yardımcı Task Id: {0}\nTask Id: {1}", ConTask.Id, tsk.Id);

            //ConTask.Wait(); // bekletmezsek main thread biter ve program kapanır.

            //Console.WriteLine("Main Thread Bitti!");


            // geri döüş değeri olanlar
            Task<bool> tsk = Task<bool>.Factory.StartNew(MyTask);
            Task<int> sumit = Task<int>.Factory.StartNew(SumInt, 5);

            Console.WriteLine("MyTask Dönüş Değeri: " + tsk.Result);

            Console.WriteLine("SumInt Dönüş Değeri: " + sumit.Result);

            sumit.Wait(); // bekletmezsek main thread biter ve program kapanır.

            tsk.Dispose(); // tsk taskini yok edelim
            sumit.Dispose(); //sumit taskini yok edelim

            Console.WriteLine("Main Thread Bitti!");

            Console.ReadLine();
        }

        static bool MyTask()
        {
            Console.WriteLine("MyTask Başladı.\n Current Id: " + Task.CurrentId);

            //for (int i = 0; i < 10; i++)
            //{
            //    Thread.Sleep(500);
            //    Console.WriteLine("MyTask count: " + i);
            //}
            Console.WriteLine("MyTask Bitti!");
            return true;
        }

        static void ContinuitaonTask(Task t)
        {
            Console.WriteLine("İkinci Task Başladı.\n Current Id: " + Task.CurrentId);

            for (int i = 10; i < 15; i++)
            {
                Thread.Sleep(500);
                Console.WriteLine("İkinci Task count: " + i);
            }
            Console.WriteLine("İkinci Task Bitti!");
        }

        static int SumInt(object v)
        {
            int sum = 0;
            int x = (int)v;

            for (int i = 1; i < x; i++)
            {
                sum += i;
            }
            return sum;
        }
        //static void MyTask()
        //{
        //    Console.WriteLine("MyTask Başladı.\n Current Id: " + Task.CurrentId);

        //    //for (int i = 0; i < 10; i++)
        //    //{
        //    //    Thread.Sleep(500);
        //    //    Console.WriteLine("MyTask count: " + i);
        //    //}
        //    Console.WriteLine("MyTask Bitti!");
        //}
    }

}
