using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading; 


namespace BOURGOGNE_Charlotte_TP3_ST2TRD
{
    public class Threads
    {
        private static Mutex m = new Mutex();
        
        public static void Print(string myCharacter, int dueTime, int period)
        {
            while (dueTime != 0)
            {
                m.WaitOne();
                Console.Write(myCharacter);
                m.ReleaseMutex();
                System.Threading.Thread.Sleep(dueTime);
                period -= 1;
            }
        }

        public static void Action()
        {
            var firstThread = new Thread(() => Print (" ", 50, 200));
            var secondThread = new Thread(() => Print ("*", 40, 275));
            var thirdThread = new Thread(() => Print ("°", 20, 450));

            firstThread.Start();
            secondThread.Start();
            thirdThread.Start();
                
            firstThread.Join();
            secondThread.Join();
            thirdThread.Join();

        }
        
        
        
    }
}