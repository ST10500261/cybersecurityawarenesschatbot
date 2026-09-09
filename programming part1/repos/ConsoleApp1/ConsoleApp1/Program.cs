using System;

namespace First
{

    class Program
    {

        static void Main(String[] args) {
            //loops:for loop, while loop and do the while loop
            ////int i = 0;
            ////while (i <= 100)
            ////{
            ////    Console.WriteLine("Count:" + i);
            ////    i++;
            ////}
            //int k = 25;
            //do
            //{
            //    Console.WriteLine(k);
            //}
            //while (k > 0);
            //foreach loop
            //Console.WriteLine("enter your name");
            //string name = Console.ReadLine().ToLower();
            //if (name.Contains("lihle") || name.Contains("doe"))
            //{
            //    Console.WriteLine($"my name is {name}");
            //}
            //else if (name.Equals("thabo")|| name.Equals("thabang"))
            //{
            //    Console.WriteLine($"my name is {name}");
            //}
            //else
            //{
            //    Console.WriteLine($"i do not understand you,you entered wrong name");
            //}
            Console.WriteLine("enter a text or exit to");
            while (true)
            {
                
                Console.Write("you:");
                string text = Console.ReadLine();
                if (text.Contains("kunjani") || text.Contains("ahee") || text.Contains("u pfukin"))
                {
                    Console.WriteLine("bot: ni pfukin kunjani");
                }
                else if (text.Contains("swa vutomi swi njani") || text.Contains("ri famba njani siku ra wena"))
                {
                    Console.WriteLine("bot:swa famba nwana mhani");
                }
                else if(text.Contains("thomas") || text.Contains("shinyori"))
                {
                    Console.WriteLine("bot:hasani chauke");
                }
                else if(text.Contains("muhlekisani")|| text.Contains("regina"))
                {
                    Console.WriteLine("bot:anga teli kuta tshama");
                }
                else if (text == "exit" || text == "stop") { break; }
                else
                {
                    Console.WriteLine("Bot:i do not understand you");
                }
            }
        
            
            //for(int count =1; count<10; count++)
            //    if (count == 7)
            //    {
            //        break;
            //    }
            //{
            //    Console.WriteLine($"Number is {count}");//string interpolation
            
            
          //string favmodules = Console.ReadLine();
            //switch (favmodules)
            //    {

            //    case "PROG6221":
            //        Console.WriteLine("PROG6221 is my fav");
            //        break;
            //    case "Database":
            //        Console.WriteLine("Database is my fav");
            //        break;
            //    case "IPMA":
            //        Console.WriteLine("IPMA is my fav");
            //        break;
            //    case "SAND":
            //        Console.WriteLine("SAND is my fav");
            //        break;
            //    default: Console.WriteLine("error:choose ipma,prog6221,sand");
            //        break;

            //    }
                //if..if..else..nestd if else statements
                /*syntax:
                 if(condition){//display results if condiction is true}
                else{
                /display results if condition is false
                }
                 */
                //Console.WriteLine("Please enter your mark");
                //int mark = int.Parse(Console.ReadLine());
                //if (mark >= 50 && mark <= 74)
                //{
                //    Console.WriteLine("pass");
                //}
                //else if (mark >= 75 && mark <= 100)
                //{
                //    Console.WriteLine("pass with distinction");
                //}
                //else if (mark >= 0 && mark < 50)
                //{
                //    Console.WriteLine("fail");
                //}


                //else
                //{
                //    Console.WriteLine("error:enter number between 0-100");

                //}
                ////comparison operators(==,===,<=,>=,<,>)
                //int num1 = 5;
                //int num2 = 5;
                ////string num3 = "5";
                //Console.WriteLine(num1 == num2);


            }

        }
    }

