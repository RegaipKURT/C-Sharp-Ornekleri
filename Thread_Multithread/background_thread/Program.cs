using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace background_thread
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Normalde bir thread oluşturduğumuz zaman main thread bitse bile oluşturduğumuz thread in işinin
             * bitmesini bekler. Ama background threadlerde ana uygulama(main method) sonlandığında background 
             * threadleri de sonlandırır. düşük öneme sahip işler için kullnılabilir. 
             * thread.IsBackground = true denilerek kullnılabilir. Aşağıda bu satırı yorum yapıp açarak görülebilir.
             */

            System.Threading.Thread myThread = new Thread(CalisacakMetod);
            myThread.IsBackground = true;
            myThread.Start();

            Thread.Sleep(2000);
            Console.WriteLine("Ana thread sona erdi.");
        }

        static void CalisacakMetod()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("İşlem " + i);
                Thread.Sleep(500);
            }
            Console.WriteLine("CalisacakMetod() thread'i sona erdi!");
            Console.ReadLine();
        }
    }
}
