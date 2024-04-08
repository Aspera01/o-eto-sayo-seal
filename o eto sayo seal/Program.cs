using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace o_eto_sayo_seal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> playlist = new List<string>(); 
            string choice = "";
            string exitchoice = "";
            string answer = "";
            bool done = false;
            bool check = false;
            while (!done)
            {
                check = false;
                choice = "";
                exitchoice = "";
                answer = "";

                Console.WriteLine("\nPlaylist Manager:\n [1] Add song\n [2] Remove song\n [3] Show playlist\n [4]Exit\n");
                choice = Console.ReadLine().ToString();

                switch (choice)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Please input the song to be put in the playlist: ");
                        answer = Console.ReadLine().ToUpper();
                        playlist.Add(answer);
                        Console.Clear();
                        Console.WriteLine("Song has been successfully added! Press any key to return to main menu...");
                        Console.ReadKey();
                        Console.Clear();
                        break; 

                    case "2":
                        Console.Clear();
                        Console.WriteLine("Please input the song to be removed from the playlist:");
                        answer = Console.ReadLine().ToUpper();
                        playlist.Add(answer);
                        for(int x = 0; x < playlist.Count; x++)
                        {
                            if (playlist[x] == answer)
                            {
                                playlist.RemoveAt(x);
                                check = true;
                            }

                        }
                        Console.Clear();
                        if (check == true)
                        {
                            Console.WriteLine("Song has been successfully removed! Press any key to return to main menu...");
                        }
                        else if (check == false)
                        {
                            Console.WriteLine("Song does not exist! Press any key to return to main menu...");
                        }
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case "3":
                        Console.Clear();
                        Console.WriteLine("The Playlist:");
                        foreach(string s in playlist)
                        {
                            Console.WriteLine(s);
                        }
                        Console.WriteLine("\nPlaylist shown! Press any key to return to main menu...");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case "4":
                        Console.WriteLine("Are you sure? (Y/N)");
                        exitchoice = Console.ReadLine().ToUpper();
                        Console.Clear();
                        if(exitchoice == "Y")
                        {
                            done = true;
                            
                        }
                        else if(exitchoice == "N")
                        {
                            done = false;
                            Console.WriteLine("Press any key to return to main menu...");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;
                }
            }          

        }
    }
}
