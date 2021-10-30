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
                    WriteLine("Rick-'Dont run away you coward!!\n\n");
                    ReadKey();
                    Clear();
                    WriteLine("Rick pulls out a plasma pistol and shoots you to death...\n\n");
                    ReadKey();
                    Clear();
                    MortyDies();
                    ReadKey();
                    Clear();
                    break;
            }
            Clear();
            WriteLine("Rick- 'Aaaaand awaaaay we go!'\n\n\nPress any key...");
            ReadKey();
            Clear();
            RunMainMenu();

        }
        public static void MortyDies()
        {
            Random r = new Random();
            int randomQuip = r.Next(0, 3);
            switch (randomQuip)
            {
                case 1:
                    Clear();
                    WriteLine("Rick- 'Morty! Morty wake up!'\n\n");
                    ReadKey();
                    Clear();
                    WriteLine("Morty-'Wha...What! Where am I?!?!'\n\n");
                    ReadKey();
                    Clear();
                    WriteLine("Rick-'Your room!'\n\n'You Were having a bad dream!!'\n\n");
                    ReadKey();
                    Clear();
                    WriteLine("Rick-'Ready to go on another adventure?'\n\nRick pulls out the portal gun..");
                    ReadKey();
                    Clear();
                    break;
                case 2:
                    Clear();
                    WriteLine("\n\nYou wake up in the garage with Rick standing over you.\n\n");
                    ReadKey();
                    Clear();
                    WriteLine("\n\nRick-'Good you're awake. I need your help..'\n\n");
                    ReadKey();
                    Clear();
                    WriteLine("\n\nRick pulls out the portal gun and pulls the trigger.\n\n");
                    ReadKey();
                    Clear();
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
                    WriteLine("You got consumed by the flames and died...");
                    MortyDies();
                    ReadKey();
                    Clear();
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
            ReadKey();
            Clear();
            OpenPortal();
            ReadKey();
            Clear();
        }
        public static void OpenPortal()
        {
            
            if (PortalGun.PortalFluid() > 0)
            {
                Random r = new Random();
                int portalSelect = r.Next(0, 9);
                switch (portalSelect)
                {
                    case 1:
                        WriteLine($"Only {PortalGun.PortalFluid()} trips left with this amount of portal fluid...");
                        ReadKey();
                        Clear();
                        BlenderDimension();
                        break;
                    case 2:
                        WriteLine($"Only {PortalGun.PortalFluid()} trips left with this amount of portal fluid...");
                        ReadKey();
                        Clear();
                        BlipsAndChitz();
                        break;
                    case 3:
                        WriteLine($"Only {PortalGun.PortalFluid()} trips left with this amount of portal fluid...");
                        ReadKey();
                        Clear();
                        CornUniverse();
                        break;
                    case 4:
                        WriteLine($"Only {PortalGun.PortalFluid()} trips left with this amount of portal fluid...");
                        ReadKey();
                        Clear();
                        MortysRoom();
                        break;
                    case 5:
                        WriteLine($"Only {PortalGun.PortalFluid()} trips left with this amount of portal fluid...");
                        ReadKey();
                        Clear();
                        ScreamingSun();
                        break;
                    case 6:
                        WriteLine($"Only {PortalGun.PortalFluid()} trips left with this amount of portal fluid...");
                        ReadKey();
                        Clear();
                        TheCitadel();
                        break;
                    case 7:
                        WriteLine($"Only {PortalGun.PortalFluid()} trips left with this amount of portal fluid...");
                        ReadKey();
                        Clear();
                        ButtWorld();
                        break;
                    case 8:
                        WriteLine($"Only {PortalGun.PortalFluid()} trips left with this amount of portal fluid...");
                        ReadKey();
                        Clear();
                        HolographicSimulation();
                        break;
                }
            }
            else
            {
                WriteLine("You are out of portal fluid!!");
                ReadKey();
                Clear();
            }
           

        }
        static void BlenderDimension()
        {
            WriteLine("You accidentally transported to the Blender Dimension and instantly got minced!!");
            ReadKey();
            Clear();
            WriteLine("You are dead from blenders");
            ReadKey();
            Clear();
            MortyDies();
            ReadKey();
            Clear();
        }
        static void BlipsAndChitz()
        {
            WriteLine("You are at Blips and Chips");
            ReadKey();
            Clear();
            string decision = "Would you like to stay at Blips and Chips or go somewhere else?";
            string[] portals = { "Portal somewhere else..", "Stay and Play!" };
            Menu portalMenu = new Menu(decision, portals);
            int selectedIndex = portalMenu.Run();
            switch (selectedIndex)
            {
                case 2:
                    
                    break;
                case 0:
                    
                    PortalGun.PortalFluid();
                    WriteLine($"Only {PortalGun.PortalFluid()} trips left with this amount of portal fluid...");
                    OpenPortal();
                    ReadKey();
                    Clear();
                    break;
                case 1:
                    BlipsAndChitzStay();
                    break;
            }
        }
        static void CornUniverse()
        {
            WriteLine("Everything is corn");
            ReadKey();
            Clear();
            string decision = "Would you like to stay and stare at corn or go somewhere else?";
            string[] portals = { "Portal somewhere else..", "Stay and...corn?" };
            Menu portalMenu = new Menu(decision, portals);
            int selectedIndex = portalMenu.Run();
            switch (selectedIndex)
            {
                case 2:

                    break;
                case 0:
                    
                    PortalGun.PortalFluid();
                    WriteLine($"Only {PortalGun.PortalFluid()} trips left with this amount of portal fluid...");
                    OpenPortal();
                    ReadKey();
                    Clear();
                    break;
                case 1:
                    CornStay();
                    ReadKey();
                    Clear();
                    break;
            }
        }
        static void MortysRoom()
        {
            WriteLine("You are in your room");
            ReadKey();
            Clear();
            Clear();
            WriteLine("Rick- 'Morty! Morty wake up!'\n\n");
            ReadKey();
            Clear();
            WriteLine("Morty-'Wha...What! Where am I?!?!'\n\n");
            ReadKey();
            Clear();
            WriteLine("Rick-'Your room!\t\tYou Were having a bad dream!!'\n\n");
            ReadKey();
            Clear();
            WriteLine("Rick-'Ready to go on another adventure?'\n\nRick pulls out the portal gun..");
            ReadKey();
            Clear();
        }
        static void ScreamingSun()
        {
            WriteLine("The sun is screaming!");
            ReadKey();
            Clear();
            string decision = "Would you like to stay and listen to the sun scream or go somewhere else?";
            string[] portals = { "Portal somewhere else..", "Stay and get screamed to death." };
            Menu portalMenu = new Menu(decision, portals);
            int selectedIndex = portalMenu.Run();
            switch (selectedIndex)
            {
                case 2:

                    break;
                case 0:
                    
                    PortalGun.PortalFluid();
                    WriteLine($"Only {PortalGun.PortalFluid()} trips left with this amount of portal fluid...");
                    OpenPortal();
                    ReadKey();
                    Clear();
                    break;
                case 1:
                    ScreamStay();
                    ReadKey();
                    Clear();
                    break;
            }
        }
        static void ButtWorld()
        {
            WriteLine("You look around and notice everything is butts.\n\nThe ground is butts...the clouds are butts...");
            ReadKey();
            Clear();
            WriteLine("The ground is butts...\n\n");
            ReadKey();
            Clear();
            WriteLine("the clouds are butts...");
            ReadKey();
            Clear();
            WriteLine("You realize that the air is unbreathable and must be mostly methane from all the farts.");
            ReadKey();
            Clear();
            WriteLine("Everything turns dark as you fade into a fart coma...");
            ReadKey();
            Clear();
            MortyDies();
            ReadKey();
            Clear();
        }
        static void TheCitadel()
        {
            WriteLine("You are at the citadel");
            ReadKey();
            Clear();
            string decision = "Would you like to stay at the citadel or go somewhere else?";
            string[] portals = { "Portal somewhere else..", "Stay and enjoy the Rick overlords." };
            Menu portalMenu = new Menu(decision, portals);
            int selectedIndex = portalMenu.Run();
            switch (selectedIndex)
            {
                case 2:

                    break;
                case 0:
                    
                    PortalGun.PortalFluid();
                    WriteLine($"Only {PortalGun.PortalFluid()} trips left with this amount of portal fluid...");
                    OpenPortal();
                    ReadKey();
                    Clear();
                    break;
                case 1:
                    CitadelStay();
                    ReadKey();
                    Clear();
                    break;
            }
        }
        static void HolographicSimulation()
        {
            WriteLine("You are in a simulation");
            ReadKey();
            Clear();
            string decision = "Would you like to stay in the simulation forever or go somewhere else?";
            string[] portals = { "Portal somewhere else..", "Stay and...simulate?" };
            Menu portalMenu = new Menu(decision, portals);
            int selectedIndex = portalMenu.Run();
            switch (selectedIndex)
            {
                case 2:

                    break;
                case 0:
                    
                    PortalGun.PortalFluid();
                    WriteLine($"Only {PortalGun.PortalFluid()} trips left with this amount of portal fluid...");
                    OpenPortal();
                    ReadKey();
                    Clear();
                    break;
                case 1:
                    SimulationStay();
                    ReadKey();
                    Clear();
                    break;
            }
        }
        public static void SimulationStay()
        {
            WriteLine("everything is a simulation");
            ReadKey();
            Clear();
        }
        public static void CitadelStay()
        {
            WriteLine("life at the citadel");
            ReadKey();
            Clear();
        }
        public static void ScreamStay()
        {
            WriteLine("Death from screaming");
            ReadKey();
            Clear();
        }
        public static void CornStay()
        {
            WriteLine("Corn");
            ReadKey();
            Clear();
        }
        public static void BlipsAndChitzStay()
        {
            WriteLine("You stay at Blips and Chipz forever");
            ReadKey();
            Clear();
        }

    }
}
