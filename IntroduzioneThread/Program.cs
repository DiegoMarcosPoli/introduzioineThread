using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;


namespace IntroduzioneThread
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("prima di avviare i thread");
            // istanzio la classe che contiene  i metodi da associarea ai thread
            MyThread tr1 = new MyThread();

            //creo due thread associati ai due metodi della calsse MyThread
            Thread t1 = new Thread(new ThreadStart(tr1.Thread1));
            Thread t2 = new Thread(new ThreadStart(tr1.Thread2));

            //avvio Thread
            t1.Start();//il metodo start equivale alla Fork
            t2.Start();

            // uccisione di un thread (attenzione all'utilizzo)
            t1.Abort();
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Main {0}", i);
            }
            Console.ReadKey();
        }

    }
    public class MyThread
    {
        public void Thread1()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Thread1 {0}", i);
            }
        }
        public  void Thread2()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Thread2 {0}", i);
            }
        }
    }


}
