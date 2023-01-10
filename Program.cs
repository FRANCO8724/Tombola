using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
class program
{
    public static void Main(string[] args)
    {
        // Variabili
        int giocatore1, giocatore2;
        Random random = new Random();

        //giocatore1

            Console.SetCursorPosition(25, 0);
            Console.WriteLine("Giocatore 1");

        //fila 1
        for (int  j= 0; j < 5; j++)
        {

                Thread.Sleep(j);
            int b = random.Next(1, 90);

                if (b == 10 || b == 20 || b == 30 || b == 40 || b == 50 || b == 60 || b == 70 || b == 80 || b == 90)
                {
                    Console.SetCursorPosition(43, 3);
                    Console.WriteLine(b);
                }
                else
                {
                    int c = ((b /10) - 2);
                    Console.SetCursorPosition((c+25), 3);
                    Console.WriteLine(b);
                }
           
        }

        //tabellone
        for (int t = 90; t < 300; t++)
        {
            Thread.Sleep(t);
            int a = random.Next(1, 90);

            if (a==10 || a==20 || a == 30 || a == 40 || a == 50 || a == 60 || a == 70 || a == 80 || a == 90)
            {
                Console.SetCursorPosition(18, ((a / 10)-1));
                Console.WriteLine(a);
            }
            else 
            {
                int b = a - ((a/10)*10);
                int c = ((b * 2)-2);
                int d = a / 10;
                Console.SetCursorPosition(c,d);
                Console.WriteLine(a);
            }

        }
    }
}