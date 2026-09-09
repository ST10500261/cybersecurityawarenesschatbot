using System;
using System.Collections;
using System.Media; 
//using System.Runtime.InteropServices;
namespace P{
    class Program{
 static void Main(string[] args)
        {
            //arrays: used to store multiple variables

            int[] marks = { 50, 78, 44, 90 };
            Console.WriteLine("the maximum number is" + marks.Max());
            Console.WriteLine(" the minimum number is" + marks.Min());
            Console.WriteLine("total num is" + marks.Sum());
            foreach (var mark in marks) { Console.WriteLine(mark); }
            int[,] numbers = { { 1, 2, 3 }, { 2, 4, 6 }, { 3, 6, 9 } 
            //string[] names = { "khensani", "tintswalo", "musa", "xitoree" };
            //names[0] = "khensani";
            //Console.WriteLine(names[0]);
            //foreach (var i in names)
            //{
            //    Console.WriteLine($"student names: (i)");
            //}
            //for (int k = 0; k< names.Length; k++)
            //{
            //    Console.WriteLine($"student names: (k)");
            //}
    //        Console.WriteLine("enter a text or exit to");
    //        while (true)
    //        {

    //            Console.Write("you:");
    //            string text = Console.ReadLine();
    //            if (text.Contains("kunjani") || text.Contains("ahee") || text.Contains("u pfukin"))
    //            {
    //                Console.WriteLine("bot: ni pfukin kunjani");
    //            }
    //            else if (text.Contains("swa vutomi swi njani") || text.Contains("ri famba njani siku ra wena"))
    //            {
    //                Console.WriteLine("bot:swa famba nwana mhani");
    //            }
    //            else if (text.Contains("thomas") || text.Contains("shinyori"))
    //            {
    //                Console.WriteLine("bot:hasani chauke");
    //            }
    //            else if (text.Contains("muhlekisani") || text.Contains("regina"))
    //            {
    //                Console.WriteLine("bot:anga teli kuta tshama");
    //            }
    //            else if (text == "exit" || text == "stop") { break; }
    //            else
    //            {
    //                Console.WriteLine("Bot:i do not understand you");
    //            }
    //        }
    //    }
    //}

