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
        Random random = new Random();
        List<int> num = Enumerable.Range(1, 90).ToList();

        //giocatore1
        for(int i = 0; i < 20; i++)
        {
            Console.SetCursorPosition(30, 0);
            Console.WriteLine("Giocatore 1");

            for (int j = 28; j < 48 ; j++)
            {
                Console.WriteLine("-");
                Console.SetCursorPosition(j, 4);
            }
            for (int j = 28; j < 50; j++)
            {
                Console.WriteLine("-");
                Console.SetCursorPosition(j, 6);
            }
        }
        //Cartella 1
        for (int j = 0; j < 16; j++)
        {
            Thread.Sleep(j);
            int b = random.Next(1, 90);

            if (j < 6)
            {



                if (b == 10 || b == 20 || b == 30 || b == 40 || b == 50 || b == 60 || b == 70 || b == 80 || b == 90)
                {

                    Console.SetCursorPosition(48, 3);
                    Console.WriteLine(" " + b);
                }
                else
                {
                    int x = b - ((b / 10) * 10);
                    int c = (x * 2);
                    Console.SetCursorPosition(c + 27, 3);
                    Console.WriteLine(" " + b);
                }
            }

            if (j > 6 || j <11)
            {



                if (b == 10 || b == 20 || b == 30 || b == 40 || b == 50 || b == 60 || b == 70 || b == 80 || b == 90)
                {

                    Console.SetCursorPosition(48, 5);
                    Console.WriteLine(" " + b);
                }
                else
                {
                    int x = b - ((b / 10) * 10);
                    int c = (x * 2);
                    Console.SetCursorPosition(c + 27, 5);
                    Console.WriteLine(" " + b);
                }
            }

            if (j >11 || j<16)
            {



                if (b == 10 || b == 20 || b == 30 || b == 40 || b == 50 || b == 60 || b == 70 || b == 80 || b == 90)
                {

                    Console.SetCursorPosition(48, 7);
                    Console.WriteLine(" " + b);
                }
                else
                {
                    int x = b - ((b / 10) * 10);
                    int c = (x * 2);
                    Console.SetCursorPosition(c + 27, 7);
                    Console.WriteLine(" " + b);
                }
            }


        }

        //giocatore2

        for (int i = 0; i < 20; i++)
        {
            Console.SetCursorPosition(65, 0);
            Console.WriteLine("Giocatore 2");

            for (int j = 63; j < 83; j++)
            {
                Console.WriteLine("-");
                Console.SetCursorPosition(j, 4);
            }
            for (int j = 63; j < 83; j++)
            {
                Console.WriteLine("-");
                Console.SetCursorPosition(j, 6);
            }
        }

        //tabellone
        for (int t = 1; t < 90; t++)
        {
            Thread.Sleep(t);
            int a = random.Next(num.Count);
            int numero = num[a];
            num.Remove(a);

            if (a==10 || a==20 || a == 30 || a == 40 || a == 50 || a == 60 || a == 70 || a == 80 || a == 90)
            {
                Console.SetCursorPosition(20, ((a / 10)-1));
                Console.WriteLine(a);
            }
            else 
            {
                int b = a - ((a/10)*10);
                int c = ((b * 2));
                int d = a / 10;
                Console.SetCursorPosition(c,d);
                Console.WriteLine(a);
            }

        }
    }
}
