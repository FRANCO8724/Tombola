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

        //lista dei numeri del tabellone
        List<int> num = Enumerable.Range(1, 90).ToList();

        //creo un array per ogni riga delle cartelle
        int[] r1 = new int[5];
        int[] r2 = new int[5];
        int[] r3 = new int[5];
        int[] r4 = new int[5];
        int[] r5 = new int[5];
        int[] r6 = new int[5];

        //Scritta tabellone
        for (int i = 0; i < 1; i++)
        {
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("Tabellone");
        }

        //Richiamo la funzione giocatore 1
        Giocatore1(args);

        //Richiamo la funzione giocatore 2
        Giocatore2(args);

        //Cartella 1

            //Riga 1
            for (int j = 0; j < 5; j++)
            {
                //estrazione numero casuale compreso tra 1 e 90
                int b = random.Next(1, 90);
                
                //Richiamo la funzione
                riga1(args, b, j);
            //Inserisco il valore estratto casualmente nell'array
                r1[j] = b;
            }

            //riga2
            for (int j = 0; j < 5; j++)
            {
               //estrazione numero casuale compreso tra 1 e 90
                int b = random.Next(1, 90);

                //Richiamo la funzione
                riga2(args, b, j);

            //Inserisco il valore estratto casualmente nell'array
            r2[j] = b;
            }

            //Riga 3
            for (int j = 0; j < 5; j++)
            {
                //Estrazione numero casuale compreso tra 1 e 90
                int b = random.Next(1, 90);

                //Richiamo la funzione
                riga3(args, b, j);

                //Inserisco il valore estratto casualmente nell'array
                r3[j] = b;
            }

            //Cartella2

            //riga 4
            for (int j = 0; j < 5; j++)
            {
                //Estrazione numero casuale compreso tra 1 e 90
                int b = random.Next(1, 90);

                //Richiamo la funzione
                riga4(args, b, j);

                //Inserisco il valore estratto casualmente nell'array
                r4[j] = b;
            }

            //Riga 5
            for (int j = 0; j < 5; j++)
            {

                //Estrazione numero casuale compreso tra 1 e 90
                int b = random.Next(1, 90);

                //Richiamo la funzione
                riga5(args, b, j);

                //Inserisco il valore estratto casualmente nell array
                r5[j] = b;
            }

            //Riga 6
            for (int j = 0; j < 5; j++)
            {
                
                //Estrazione numero casuale compreso tra 1 e 90
                int b = random.Next(1, 90);

                //Richiamo la funzione
                riga6(args, b, j);

                //Inserisco il valore estratto casualmente nell array
                r6[j] = b;
            }


            //tabellone

            for (int t = 1; t < 900; t++)
            {
                Thread.Sleep(t);

                //Estraggo il numero casuale dalla lista 
                int a = random.Next(num.Count);
                int numero = num[a];

                //Richiamo la funzione per la stesura del tabellone
                Tabellone(args, numero);

            }

            //Condizione per verificare la tombola e indicare chi ha vinto
                     
    }

    

    //elenco delle funzioni che ho richiamato in precedenza

        static void Giocatore1(string[] args)
        {
            for (int i = 0; i < 20; i++)
            {
            //Posiziono la scritta
                Console.SetCursorPosition(30, 0);
                Console.WriteLine("Giocatore 1");

                //Trattini per separare le righe delle cartelle
                for (int j = 30; j < 45; j++)
                {
                    Console.WriteLine("-");
                    Console.SetCursorPosition(j, 4);
                }
                for (int j = 30; j < 46; j++)
                {
                    Console.WriteLine("-");
                    Console.SetCursorPosition(j, 6);
                }
            }
        }

    static void Giocatore2(string[] args)
    {
        for (int i = 0; i < 20; i++)
        {
            //Posiziono la scritta
            Console.SetCursorPosition(65, 0);
            Console.WriteLine("Giocatore 2");

            //Trattini per separare le righe delle cartelle
            for (int j = 63; j < 78; j++)
            {
                Console.WriteLine("-");
                Console.SetCursorPosition(j, 4);
            }
            for (int j = 63; j < 79; j++)
            {
                Console.WriteLine("-");
                Console.SetCursorPosition(j, 6);
            }
        }
    }

    static void Tabellone(string[] args, int a)
        {
            //Divido i valori che devono andare più lontani rispetto al tabellone dal resto degli altri numeri 
            if (a == 10 || a == 20 || a == 30 || a == 40 || a == 50 || a == 60 || a == 70 || a == 80 || a == 90)
            {
                Console.SetCursorPosition(18, (a / 10));
                Console.WriteLine(a);
            }
            else
            {
                int b = a - ((a / 10) * 10);
                int c = ((b * 2));
                int d = a / 10;
                Console.SetCursorPosition((c-2), (d+1));
                Console.WriteLine(a);
            }
        }

    //Calcolo e indico la posizione di ogni numero sulla riga della cartella associando ognuna di essa a una funzione che ho richiamato in precedenza
        static void riga1(string[] args,int b,int j)
        {
            int c = ((j * 3));
            Console.SetCursorPosition(c + 30, 3);
            Console.WriteLine(" " + b);
        }

        static void riga2(string[] args, int b,int j)
        {
            int c = ((j * 3));
            Console.SetCursorPosition(c + 30, 5);
            Console.WriteLine(" " + b);
        }

        static void riga3(string[] args, int b,int j)
        {
            int c = ((j * 3));
            Console.SetCursorPosition(c + 30, 7);
            Console.WriteLine(" " + b);
        }

        static void riga4(string[] args, int b,int j)
        {
            int c = ((j * 3));
            Console.SetCursorPosition(c + 62, 3);
            Console.WriteLine(" " + b);
        }

        static void riga5(string[] args, int b,int j)
        {
            int c = ((j * 3));
            Console.SetCursorPosition(c + 62, 5);
            Console.WriteLine(" " + b);
        }

        static void riga6(string[] args, int b, int j)
        {
            int c = ((j * 3));
            Console.SetCursorPosition(c + 62, 7);
            Console.WriteLine(" " + b);
        }
    
}
