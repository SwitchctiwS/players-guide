using System;
using System.Threading;

namespace Threads {
    class MainClass{
        public static void Main(string[] args) {
            Thread thread1 = new Thread(Frog);
            Thread thread2 = new Thread(Frog);
            Thread thread3 = new Thread(Frog);

            thread1.Start(1);
            thread2.Start(2);
            thread3.Start(3);

            thread1.Join();
            thread2.Join();
            thread3.Join();
        }

        public static void Frog(object objNum) {
            Random rand = new Random();
            for (int jump = 1; jump < 11; jump++) {
                Console.WriteLine($"Frog #{(int)objNum} jumped!");
                Thread.Sleep(rand.Next(0, 1001));
            }

            Console.WriteLine($"Frog #{(int)objNum} finished.");                
        }
    }
}
