

using System.ComponentModel;
using System.ComponentModel.Design;
using System.Reflection;

namespace WordOfGod
{
    internal class Program
    {
        static int y = 7;
        static void Main(string[] args)
        {
            string poop = "";
            while (poop != "poop")
            {
                Console.BufferHeight = 200;
                Console.BufferWidth = 200;
                Console.WindowHeight = 40;
                Console.WindowWidth = 120;
                Console.WriteLine("1. Random Words of God");
                Console.WriteLine("2. Talk to god");
                Console.WriteLine("3. Quit");
                Console.Write("Choice: ");
                poop = Console.ReadLine();
                if (poop == "1")
                {
                    RandomWords();
                    y += 10;
                }
                else if (poop == "2")
                {
                    TalkTo();
                    y += 10;
                }
                else if (poop == "3")
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("INCORRECT OPTION");
                }
            }  
        }

       
        public static void RandomWords()
        {
            string resourceName = "WordOfGod.KJV.txt";

            Assembly assembly = Assembly.GetExecutingAssembly();

            StreamReader sr = new StreamReader(assembly.GetManifestResourceStream(resourceName));
            Random randint = new Random();
            string[] splittent = sr.ReadToEnd().Split('\n', ' ');
            int i = 0;
            int x = 0;

            Console.WriteLine("Press Down Arrow to make words appear (Random Words of God)");
            Console.WriteLine("Press Q to stop");
            Console.WriteLine("####################################################");

            int randnum;

         
            while (true)
            {

                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                if (keyInfo.KeyChar != 'q' && keyInfo.KeyChar != 'Q')
                {
                    randnum = randint.Next(0, splittent.Length);
                    x += splittent[randnum].Length + 1;
                    Console.Write(splittent[randnum] + " ");

                    Console.SetCursorPosition(x, y);
                    i++;
                    if (i == 10)
                    {
                        Console.Write("\n");
                        i = 0;
                        y++;
                        x = 0;
                        if (y == 200)
                        {
                            break;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("\n####################################################");
                    Console.WriteLine("FINISHED!");
                    break;
                }
            }
        }
        public static void TalkTo()
        {
            y += 2;
            string resourceName = "WordOfGod.KJV.txt";

            Assembly assembly = Assembly.GetExecutingAssembly();


            StreamReader sr = new StreamReader(assembly.GetManifestResourceStream(resourceName));
            Random randint = new Random();
            string[] splittent = sr.ReadToEnd().Split('\n', ' ');
            
            int x = 0;
            int z = 0;

            Console.WriteLine("Talk to God!");
            Console.WriteLine("Press Q to stop");
            Console.WriteLine("####################################################");

            int randnum;


            while (true)
            {
                Console.Write("\nSay something to god: ");
                string talk = Console.ReadLine();
                if (talk != "q" && talk != "Q")
                {
                    while (z < 20)
                    {
                        randnum = randint.Next(0, splittent.Length);
                        x += splittent[randnum].Length + 1;
                        
                        Console.Write(splittent[randnum] + " ");
                        Console.SetCursorPosition(x, y);

                        z++;
                    }
                    x = 0;
                    y += 2;
                    z = 0;
                    if (y == 200)
                    {
                        break;
                    }

                }
                else
                {
                    Console.WriteLine("\n####################################################");
                    Console.WriteLine("FINISHED!");
                    break;
                }
            }
        }
    }
}