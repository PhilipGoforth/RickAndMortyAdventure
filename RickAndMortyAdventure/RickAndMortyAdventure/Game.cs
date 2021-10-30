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
            Clear();
            WriteLine("You are asleep and suddenly your bedroom door flings open!!\n\nRick-'Hey little buddy...Hey how you doing in here??'\n\n");
            WriteLine("Morty-'Oh geez Rick what are you doing in here??'\n\nRick-'I need you to come to the garage and help me fix my Ionic Difibulizer!'\n\n");
            
            ReadKey();
            Clear();
            WriteLine("You enter the garage and notice a strange looking device on Ricks workbench.\n\n");
            WriteLine("Rick-'Now Morty what do you say can you hand me a screwdriver so I can finish my Ionic Difibulizer?'\n\nMorty-'Sure thing Rick here's a screwdriver..'");
            WriteLine("\n\nRick takes the screw driver and starts tightening a screw on the machine...\n\n");
            
            ReadKey();
            Clear();
            WriteLine("Rick-'Alrighty, One screw turn...Two screw turns...'\n\nSuddenly the device explodes injuring rick and catching the house on fire!!\n\n ");
            WriteLine("You've got to get out of here!! What do you do?!?!?!\n\n");
            ReadKey();
            Clear();
            string decision = "Quick make a split decision!!";
            string[] portals = { "'Oh geez Rick'", "Grab the portal gun and pull the trigger!", "Run away!" };
            Menu portalMenu = new Menu(decision, portals);
            int selectedIndex = portalMenu.Run();
            switch (selectedIndex)
            {
                case 0:
                    RickQuip();
                    break;
                case 1:
                    Portal();
                    break;
                case 2:
                    MortyDies();
                    break;
            }
            Clear();
            WriteLine("Rick- 'Aaaaand awaaaay we go!'\n\n\nPress any key...");
            ReadKey();
            Clear();
            RunMainMenu();

        }
        public void MortyDies()
        {
            Random r = new Random();
            int randomDeath = r.Next(0, 7);
            switch (randomDeath)
            {
                case 1:
                    WriteLine();
                    break;
                case 2:
                    WriteLine();
                    break;
                case 3:
                    WriteLine();
                    break;
                case 4:
                    WriteLine();
                    break;
                case 5:
                    WriteLine();
                    break;
                case 6:
                    WriteLine();
                    break;
            }
        }
        public void RickQuip()
        {
            Randomizer();
            ReadKey();
            Clear();
            string decision = "Quick choose run or portal!!";
            string[] portals = { "Grab the portal gun and pull the trigger!", "Run away!" };
            Menu portalMenu = new Menu(decision, portals);
            int selectedIndex = portalMenu.Run();
            switch (selectedIndex)
            {
                case 2:
                    RickQuip();
                    break;
                case 0:
                    Portal();
                    break;
                case 1:
                    MortyDies();
                    break;
            }
        }
        public void Randomizer()
        {
            Random r = new Random();
            int randomQuip = r.Next(0, 7);
            switch (randomQuip)
            {
                case 1:
                    Clear();
                    WriteLine("\n\nRick-'Morty you piece of $#!7!!'");
                    break;
                case 2:
                    Clear();
                    WriteLine("\n\nRick-'Calm down Morty stop freaking out!!'");
                    break;
                case 3:
                    Clear();
                    WriteLine("\n\nRick-'You wanna die Morty?!? Do you!?!'");
                    break;
                case 4:
                    Clear();
                    WriteLine("\n\nRick-'Oh I'm sorry Morty are you having a hard time being stupid!!'");
                    break;
                case 5:
                    Clear();
                    WriteLine("\n\nRick-'There is no God in your face God!!'");
                    break;
                case 6:
                    Clear();
                    WriteLine("\n\nRick-'I don't want to die you idiot!'");
                    break;
            }
        }
        public void Portal()
        {
            Clear();
            ForegroundColor = ConsoleColor.Green;
            WriteLine("\n\n\t\t\t\t\t\tyou open a portal and jump in...");
            Random r = new Random();
            int portalSelect = r.Next(0, 100);
            switch (portalSelect)
            {
                case 1:

                    break;
                case 2:

                    break;
                case 3:

                    break;
                case 4:

                    break;
                case 5:

                    break;
                case 6:

                    break;
            }
        }
    }
}
