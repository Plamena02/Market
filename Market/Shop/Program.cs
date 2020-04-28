﻿using Shop.View;
using System;
using System.Threading;
using System.Timers;

namespace Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Timers.Timer aTimer = new System.Timers.Timer();
            aTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            //aTimer.Interval = 10;
            aTimer.AutoReset = false;
            aTimer.Start();
            Thread.Sleep(7000);
            Console.CursorVisible = true;
            Display display = new Display();

        }
        private static void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            for (int a = 6; a > 0; a--)
            {
            Console.CursorVisible = false;
            //Console.WriteLine(new string(' ', 20));
            //Console.WriteLine(new string(' ', 20));
            //Console.WriteLine(new string(' ', 20));
            //Console.WriteLine(new string(' ', 20));
            //Console.WriteLine(new string(' ', 10));
            Console.Write(new string(' ', 2));
            Console.WriteLine(new string('*', 42));
            Console.Write(new string(' ', 2));
            Console.WriteLine("* Market Created by Muhamed and Plmanena *");
            Console.Write(new string(' ', 2));
            Console.WriteLine(new string('*', 42));
            Console.WriteLine("");
            Console.Write("The program will start after: {0}", a);
            System.Threading.Thread.Sleep(1000);
            Console.Clear();
            }


        }
    }
}
