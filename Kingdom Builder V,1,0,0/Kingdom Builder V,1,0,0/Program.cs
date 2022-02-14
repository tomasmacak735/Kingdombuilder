using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace KingdomBuilder_V1
{
    class Program
    {
        static void save(string[,] lokace)
        {
            string E = null;
            for (int y = 0; y < 10; y++)
            {


                for (int i = 0; i < 10; i++)
                {
                    E = E + lokace[i, y] + "/";
                }
                E = E + "/";
            }

        }
        static void search(string[,] pole, string[,] lokace, int[] prev, int A, int B)
        {
            for (int X = 0; X < 10; X++)
            {
                for (int Y = 0; Y < 10; Y++)
                {
                    switch (lokace[X, Y])
                    {
                        case "1":
                            pole[prev[X], prev[Y]] = "/";
                            pole[prev[X], prev[Y] + 1] = "\\ ";
                            pole[prev[X] + 1, prev[Y]] = "█";
                            pole[prev[X] + 1, prev[Y] + 1] = "█ ";
                            break;
                        case "0":
                            pole[prev[X], prev[Y]] = ".";
                            pole[prev[X], prev[Y] + 1] = ". ";
                            pole[prev[X] + 1, prev[Y]] = ".";
                            pole[prev[X] + 1, prev[Y] + 1] = ". ";
                            break;
                        case "2":
                            pole[prev[X], prev[Y]] = "..";
                            pole[prev[X], prev[Y] + 1] = ".. ";
                            pole[prev[X] + 1, prev[Y]] = "..";
                            pole[prev[X] + 1, prev[Y] + 1] = ".. ";
                            break;
                        case "3":
                            pole[prev[X], prev[Y]] = "_";
                            pole[prev[X], prev[Y] + 1] = "_ ";
                            pole[prev[X] + 1, prev[Y]] = "|";
                            pole[prev[X] + 1, prev[Y] + 1] = "| ";
                            break;
                        case "4":
                            pole[prev[X], prev[Y]] = "☼";
                            pole[prev[X], prev[Y] + 1] = "☼ ";
                            pole[prev[X] + 1, prev[Y]] = "|";
                            pole[prev[X] + 1, prev[Y] + 1] = "| ";
                            break;



                    }
                }
            }
            for (int i = 0; i < 20; i++)
            {
                for (int y = 0; y < 20; y++)
                {
                    if (prev[A] == i && prev[B] == y)
                    { Console.BackgroundColor = ConsoleColor.Yellow; }
                    if (prev[A] == i && prev[B] + 1 == y)
                    { Console.BackgroundColor = ConsoleColor.Yellow; }
                    if (prev[A] + 1 == i && prev[B] == y)
                    { Console.BackgroundColor = ConsoleColor.Yellow; }
                    if (prev[A] + 1 == i && prev[B] + 1 == y)
                    { Console.BackgroundColor = ConsoleColor.Yellow; }
                    switch (pole[i, y])
                    {
                        case "/":
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write("/");
                            break;
                        case "\\ ":
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write("\\");
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.Write(" ");
                            break;
                        case "█":
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.Write("█");
                            break;
                        case "█ ":
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.Write("█");
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.Write(" ");
                            break;
                        case ".":
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("░");
                            break;
                        case ". ":
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("░");
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.Write(" ");
                            break;
                        case "..":
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.Write("░");
                            break;
                        case ".. ":
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.Write("░");
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.Write(" ");
                            break;
                        case "|":
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.Write("|");
                            break;
                        case "| ":
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.Write("|");
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.Write(" ");
                            break;
                        case "☼":
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("☼");

                            break;
                        case "☼ ":
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("☼");
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.Write(" ");
                            break;
                        case "_":
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.Write("_");
                            break;
                        case "_ ":
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.Write("_");
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.Write(" ");
                            break;
                        case "▲":
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.Write("▲");
                            break;
                    }
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                Console.WriteLine();
                if (i % 2 == 1) Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Gray;


            }
        }


        static void blblb(string[,] pole, string[,] lokace, int[] prev, ref int A, ref int B)
        {
            int Ø = 0;
            while (Ø != 69)
            {

                var ch = Console.ReadKey(false).Key;
                Console.Clear();
                switch (ch)
                {
                    case ConsoleKey.Spacebar:
                        Ø = 69;
                        break;
                    case ConsoleKey.UpArrow:
                        if (A != 0)
                            A -= 1;
                        break;
                    case ConsoleKey.DownArrow:
                        if (A != 9)
                        { A += 1; }

                        break;
                    case ConsoleKey.RightArrow:
                        if (B != 9)
                            B += 1;
                        break;
                    case ConsoleKey.LeftArrow:
                        if (B != 0)
                            B -= 1;
                        break;
                    case ConsoleKey.W:
                        if (A != 0)
                            A -= 1;
                        break;
                    case ConsoleKey.S:
                        if (A != 9)
                        { A += 1; }

                        break;
                    case ConsoleKey.D:
                        if (B != 9)
                            B += 1;
                        break;
                    case ConsoleKey.A:
                        if (B != 0)
                            B -= 1;
                        break;
                }
                search(pole, lokace, prev, A, B);
            }
        }
        static void map(string[,] pole, string[,] lokace, int[] prev)
        {

            for (int X = 0; X < 10; X++)
            {
                for (int Y = 0; Y < 10; Y++)
                {
                    switch (lokace[X, Y])
                    {
                        case "1":
                            pole[prev[X], prev[Y]] = "/";
                            pole[prev[X], prev[Y] + 1] = "\\ ";
                            pole[prev[X] + 1, prev[Y]] = "█";
                            pole[prev[X] + 1, prev[Y] + 1] = "█ ";
                            break;
                        case "0":
                            pole[prev[X], prev[Y]] = ".";
                            pole[prev[X], prev[Y] + 1] = ". ";
                            pole[prev[X] + 1, prev[Y]] = ".";
                            pole[prev[X] + 1, prev[Y] + 1] = ". ";
                            break;
                        case "2":
                            pole[prev[X], prev[Y]] = "..";
                            pole[prev[X], prev[Y] + 1] = ".. ";
                            pole[prev[X] + 1, prev[Y]] = "..";
                            pole[prev[X] + 1, prev[Y] + 1] = ".. ";
                            break;
                        case "3":
                            pole[prev[X], prev[Y]] = "_";
                            pole[prev[X], prev[Y] + 1] = "_ ";
                            pole[prev[X] + 1, prev[Y]] = "|";
                            pole[prev[X] + 1, prev[Y] + 1] = "| ";
                            break;
                        case "4":
                            pole[prev[X], prev[Y]] = "☼";
                            pole[prev[X], prev[Y] + 1] = "☼ ";
                            pole[prev[X] + 1, prev[Y]] = "|";
                            pole[prev[X] + 1, prev[Y] + 1] = "| ";
                            break;



                    }
                }
            }
            for (int i = 0; i < 20; i++)
            {
                for (int y = 0; y < 20; y++)
                {
                    switch (pole[i, y])
                    {
                        case "/":
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write("/");
                            break;
                        case "\\ ":
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write("\\ ");
                            break;
                        case "█":
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.Write("█");
                            break;
                        case "█ ":
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.Write("█ ");
                            break;
                        case ".":
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("░");
                            break;
                        case ". ":
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("░ ");
                            break;
                        case "..":
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.Write("░");
                            break;
                        case ".. ":
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.Write("░ ");
                            break;
                        case "|":
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.Write("|");
                            break;
                        case "| ":
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.Write("| ");
                            break;
                        case "☼":
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("☼");
                            break;
                        case "☼ ":
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("☼ ");
                            break;
                        case "_":
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.Write("_");
                            break;
                        case "_ ":
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.Write("_ ");
                            break;
                        case "▲":
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.Write("▲");
                            break;
                    }
                }
                Console.WriteLine();
                if (i % 2 == 1) Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Gray;
            }
        }
        static void Main(string[] args)
        {

            string[,] lokace = new string[10, 10];
            string[,] pole = new string[20, 20];
            int[] prev = { 0, 2, 4, 6, 8, 10, 12, 14, 16, 18 };
            int penize = 10, jidlo = 10, drevo = 20, kamen = 10, pracovnici = 0, X, Y;
            bool hra = Convert.ToBoolean(1), akce;
            for (X = 0; X < 10; X++)
            {
                for (Y = 0; Y < 10; Y++)
                {
                    lokace[X, Y] = "0";
                }
            }
            for (X = 0; X < 10; X++)
            {
                for (Y = 0; Y < 10; Y++)
                {
                    switch (lokace[X, Y])
                    {
                        case "1":
                            pole[prev[X], prev[Y]] = "/";
                            pole[prev[X], prev[Y] + 1] = "\\ ";
                            pole[prev[X] + 1, prev[Y]] = "█";
                            pole[prev[X] + 1, prev[Y] + 1] = "█ ";
                            break;
                        case "0":
                            pole[prev[X], prev[Y]] = ".";
                            pole[prev[X], prev[Y] + 1] = ". ";
                            pole[prev[X] + 1, prev[Y]] = ".";
                            pole[prev[X] + 1, prev[Y] + 1] = ". ";
                            break;
                        case "2":
                            pole[prev[X], prev[Y]] = "..";
                            pole[prev[X], prev[Y] + 1] = ".. ";
                            pole[prev[X] + 1, prev[Y]] = "..";
                            pole[prev[X] + 1, prev[Y] + 1] = ".. ";
                            break;
                        case "3":
                            pole[prev[X], prev[Y]] = "_";
                            pole[prev[X], prev[Y] + 1] = "_ ";
                            pole[prev[X] + 1, prev[Y]] = "|";
                            pole[prev[X] + 1, prev[Y] + 1] = "| ";
                            break;
                        case "4":
                            pole[prev[X], prev[Y]] = "☼";
                            pole[prev[X], prev[Y] + 1] = "☼ ";
                            pole[prev[X] + 1, prev[Y]] = "|";
                            pole[prev[X] + 1, prev[Y] + 1] = "| ";
                            break;
                    }
                }
            }

            while (hra)
            {

                akce = Convert.ToBoolean(1);
                while (akce)
                {
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine(" penize:" + penize + " jidlo:" + jidlo + " drevo:" + drevo + " kamen:" + kamen + " pracovnici:" + pracovnici);
                    Console.WriteLine();
                    Console.WriteLine("Co si přejete ukonat milorde?" + Environment.NewLine + "1. Postavit Dům (5 jídla + 2 kameny + 5 dřeva)" + Environment.NewLine + "2. postavit farmu (5 dřeva + 1 pracovník)");
                    Console.WriteLine("3. Kamenolom(4 dřeva + 1 pracovník)" + Environment.NewLine + "4. drevorubec(4 kameny + 1 pracovník)");
                    Console.WriteLine("0. už nic" + Environment.NewLine + "9. konec");
                    map(pole, lokace, prev);
                    int E = 999;
                    try
                    {
                        E = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("neplatný input");
                    }
                    switch (E)
                    {
                        case 1:
                            {
                                if (jidlo > 4)
                                {
                                    if (kamen > 1)
                                    {
                                        if (drevo > 4)
                                        {
                                            int A = 0, B = 0;
                                            blblb(pole, lokace, prev, ref A, ref B);
                                            lokace[A, B] = "1";
                                            jidlo -= 5;
                                            kamen -= 2;
                                            drevo -= 5;
                                            pracovnici += 1;
                                        }
                                        else { Console.WriteLine("nedostatek jídla"); Console.ReadLine(); }
                                    }
                                    else { Console.WriteLine("nedostatek kamene"); Console.ReadLine(); }
                                }
                                else { Console.WriteLine("nedostatek dřeva"); Console.ReadLine(); }


                            }
                            break;
                        case 2:
                            if (drevo > 4)
                            {
                                if (pracovnici > 0)
                                {

                                    int A = 0, B = 0;
                                    blblb(pole, lokace, prev, ref A, ref B);

                                    lokace[A, B] = "2";
                                    drevo -= 5;
                                    pracovnici -= 1;

                                }
                                else { Console.WriteLine("nedostatek pracantů"); Console.ReadLine(); }
                            }
                            else { Console.WriteLine("nedostatek dřeva"); Console.ReadLine(); }
                            break;
                        case 3:
                            if (drevo > 3)
                            {
                                if (pracovnici > 0)
                                {


                                    int A = 0, B = 0;
                                    blblb(pole, lokace, prev, ref A, ref B);
                                    lokace[A, B] = "3";
                                    drevo -= 4;
                                    pracovnici -= 1;

                                }
                                else { Console.WriteLine("nedostatek pracantů"); Console.ReadLine(); }
                            }
                            else { Console.WriteLine("nedostatek dřeva"); Console.ReadLine(); }
                            break;
                        case 4:
                            if (kamen > 3)
                            {
                                if (pracovnici > 0)
                                {


                                    int A = 0, B = 0;
                                    blblb(pole, lokace, prev, ref A, ref B);
                                    lokace[A, B] = "3";
                                    kamen -= 4;
                                    pracovnici -= 1;

                                }
                                else { Console.WriteLine("nedostatek pracantů"); Console.ReadLine(); }
                            }
                            else { Console.WriteLine("nedostatek kamene"); Console.ReadLine(); }
                            break;
                        case 0:
                            akce = Convert.ToBoolean(0);
                            break;

                        case 9:
                            akce = Convert.ToBoolean(0);
                            hra = Convert.ToBoolean(0);
                            break;

                    }

                }
                for (int i = 0; i < 10; i++)
                {
                    for (int y = 0; y < 10; y++)
                    {
                        switch (lokace[i, y])
                        {
                            case "1":
                                drevo -= 1;
                                jidlo -= 1;
                                break;
                            case "2":
                                jidlo += 7;
                                break;
                            case "3":
                                drevo -= 1;
                                jidlo -= 1;
                                kamen += 2;
                                break;
                            case "4":
                                kamen -= 1;
                                jidlo -= 1;
                                drevo += 5;
                                break;
                        }
                    }
                }
                if (drevo < 0)
                { hra = Convert.ToBoolean(0); Console.Clear(); Console.WriteLine("došlo dřevo v celém království, všichni umrzli"); Console.ReadLine(); }
                if (jidlo < 0)
                { hra = Convert.ToBoolean(0); Console.Clear(); Console.WriteLine("tvé království vymřelo hlady, všichni jsou mrtví"); Console.ReadLine(); }


                Console.Beep();
            }

        }
    }
}
