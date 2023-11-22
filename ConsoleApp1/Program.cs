using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        [Obsolete]
        static void Main()
        {
            //create + initialize a Unstarted thread
            Thread thread = new Thread(SomeMethod);
            Console.WriteLine($"Before Start, IsAlive:{thread.IsAlive}, ThreadState:{thread.ThreadState}");

            //Runing State
            thread.Start();
            Console.WriteLine($"After Start(), IsAlive:{thread.IsAlive}, ThreadState:{thread.ThreadState}");


            //thread is in suspend State
            thread.Suspend();
            Thread.Sleep(3000);
            Console.WriteLine($"After Suspend(), IsAlive:{thread.IsAlive}, ThreadState:{thread.ThreadState}");


            //thread is resume to running State
            thread.Resume();
            Console.WriteLine($"After Resume(), IsAlive:{thread.IsAlive}, ThreadState:{thread.ThreadState}");


            //thread is in Abort State
            thread.Abort();

            Console.WriteLine($"After Abort(), IsAlive:{thread.IsAlive}, ThreadState:{thread.ThreadState}");
            Thread.Sleep(4000);
            Console.WriteLine($"After Abort(), IsAlive:{thread.IsAlive}, ThreadState:{thread.ThreadState}");
            Console.ReadLine();
        }
        public static void SomeMethod()
        {
            for (int i = 0; i < 3; i++)
            {
                Thread.Sleep(3000);
            }
            Console.WriteLine("SomeMethod Completed.....");
        }
    }
}

