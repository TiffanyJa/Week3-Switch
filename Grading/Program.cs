﻿using System;

namespace Grading
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib, mis hinde kasutaja sai
            //kui kasutaja sai "A", konsool kuvab "Suurepärane!";
            //"B", konsool kuvab "Väga hea!";
            //"C", konsool kuvab "Hea!";
            //"D", konsool kuvab "Rahuldav";
            //"E", konsool kuvab "Kasin";
            //"F", konsool kuvab "Puudulik".
            //kui kasutaja sisestab midagi muud, siis konsool kuvab "Vale väärtus."

            Console.WriteLine("Sisesta oma tulemus:");
            //char-character
            char userResult = Convert.ToChar(Console.ReadLine().ToUpper());

            if (userResult == 'A')
            {
                Console.WriteLine("Suurepärane!");
            }
            else if (userResult == 'B')
            {
                Console.WriteLine("Väga hea!");
            }
            else if (userResult == 'C')
            {
                Console.WriteLine("Hea!");
            }
            else if ( userResult =='D')
            {
                Console.WriteLine("Rahuldav");
            }
            else if (userResult == 'E')
            {
                Console.WriteLine("Kasin");
            }
            else if(userResult =='E')
            {
                Console.WriteLine("Puudulik");
            }
            else
            {
                Console.WriteLine( "Vale väärtus");
            }
            
        }
    }
}
