using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace RickAndMortyAdventure
{
    class Game
    {
        public void Start()
        {



            Title = "Rick and Morty Simulator.";
            RunMainMenu();

            
        }
        private void RunMainMenu()
        {
            string prompt = @"
██████╗ ██╗ ██████╗██╗  ██╗     █████╗ ███╗   ██╗██████╗     ███╗   ███╗ ██████╗ ██████╗ ████████╗██╗   ██╗
██╔══██╗██║██╔════╝██║ ██╔╝    ██╔══██╗████╗  ██║██╔══██╗    ████╗ ████║██╔═══██╗██╔══██╗╚══██╔══╝╚██╗ ██╔╝
██████╔╝██║██║     █████╔╝     ███████║██╔██╗ ██║██║  ██║    ██╔████╔██║██║   ██║██████╔╝   ██║    ╚████╔╝ 
██╔══██╗██║██║     ██╔═██╗     ██╔══██║██║╚██╗██║██║  ██║    ██║╚██╔╝██║██║   ██║██╔══██╗   ██║     ╚██╔╝  
██║  ██║██║╚██████╗██║  ██╗    ██║  ██║██║ ╚████║██████╔╝    ██║ ╚═╝ ██║╚██████╔╝██║  ██║   ██║      ██║   
╚═╝  ╚═╝╚═╝ ╚═════╝╚═╝  ╚═╝    ╚═╝  ╚═╝╚═╝  ╚═══╝╚═════╝     ╚═╝     ╚═╝ ╚═════╝ ╚═╝  ╚═╝   ╚═╝      ╚═╝                   
          _______. __  .___  ___.  __    __   __          ___   .___________.  ______   .______      
         /       ||  | |   \/   | |  |  |  | |  |        /   \  |           | /  __  \  |   _  \     
        |   (----`|  | |  \  /  | |  |  |  | |  |       /  ^  \ `---|  |----`|  |  |  | |  |_)  |    
         \   \    |  | |  |\/|  | |  |  |  | |  |      /  /_\  \    |  |     |  |  |  | |      /     
     .----)   |   |  | |  |  |  | |  `--'  | |  `----./  _____  \   |  |     |  `--'  | |  |\  \----.
     |_______/    |__| |__|  |__|  \______/  |_______/__/     \__\  |__|      \______/  | _| `._____|
                                                                                                
                Welcome to another Rick and Morty Adventure! What would you like to do?
                               (Use arrow keys and Enter to select.)";
            string[] options = { "Play", "About", "Exit" };
            Menu mainMenu = new Menu(prompt, options);
            int selectedIndex = mainMenu.Run();
            switch (selectedIndex)
            {
                case 0:
                    RunChoice();
                    break;
                case 1:
                    DisplayAbout();
                    break;
                case 2:
                    ExitGame();
                    break;
            }
        }
        private void ExitGame()
        {
            WriteLine("\nPress any key to exit...");
            ReadKey(true);
            Environment.Exit(0);
        }
        private void DisplayAbout()
        {
            Clear();
            WriteLine("This simulator was created by Philip Goforth.");
            WriteLine("Help was provided by Googling and YouTube tutorials...");
            WriteLine("Assets from http://patorjk.com/software/taag");
            WriteLine("Press any key to return to the menu.");
            ReadKey(true);
            RunMainMenu();
        }
        private void RunChoice()
        {
            WriteLine("game goes here");
            ExitGame();
        }
    }
}
