using System;
using System.Collections.Generic;
using System.Text;

namespace RickAndMortyAdventure
{
    class Dimensions
    {
        public static void BlenderDimension()
        {
            Console.WriteLine("You accidentally transported to the Blender Dimension and instantly got minced!!");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("You are dead from blenders");
            Console.ReadKey();
            Console.Clear();
            Morty.MortyDies();
            Console.ReadKey();
            Console.Clear();
        }
        public static void BlipsAndChitz()
        {
            Console.WriteLine("You are at Blips and Chips");
            Console.ReadKey();
            Console.Clear();
            string decision = "Would you like to stay at Blips and Chips or go somewhere else?";
            string[] portals = { "Portal somewhere else..", "Stay and Play!" };
            Menu portalMenu = new Menu(decision, portals);
            int selectedIndex = portalMenu.Run();
            switch (selectedIndex)
            {
                

                    
                case 0:



                    PortalGun.Portal();
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 1:
                    BlipsAndChitzStay();
                    break;
            }
        }
        public static void CornUniverse()
        {
            Console.WriteLine("Everything is corn");
            Console.ReadKey();
            Console.Clear();
            string decision = "Would you like to stay and stare at corn or go somewhere else?";
            string[] portals = { "Portal somewhere else..", "Stay and...corn?" };
            Menu portalMenu = new Menu(decision, portals);
            int selectedIndex = portalMenu.Run();
            switch (selectedIndex)
            {
                case 2:

                    break;
                case 0:



                    PortalGun.Portal();
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 1:
                    CornStay();
                    Console.ReadKey();
                    Console.Clear();
                    break;
            }
        }
        public static void MortysRoom()
        {
            Console.WriteLine("You are in your room");
            Console.ReadKey();
            
            Console.Clear();
            Console.WriteLine("Rick- 'Morty! Morty wake up!'\n\n");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Morty-'Wha...What! Where am I?!?!'\n\n");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Rick-'Your room!\t\tYou Were having a bad dream!!'\n\n");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Rick-'Ready to go on another adventure?'\n\nRick pulls out the portal gun..");
            Console.ReadKey();
            Console.Clear();
        }
        public static void ScreamingSun()
        {
            Console.WriteLine("The sun is screaming!");
            Console.ReadKey();
            Console.Clear();
            string decision = "Would you like to stay and listen to the sun scream or go somewhere else?";
            string[] portals = { "Portal somewhere else..", "Stay and get screamed to death." };
            Menu portalMenu = new Menu(decision, portals);
            int selectedIndex = portalMenu.Run();
            switch (selectedIndex)
            {
                case 2:

                    break;
                case 0:



                    PortalGun.Portal();
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 1:
                    ScreamStay();
                    Console.ReadKey();
                    Console.Clear();
                    break;
            }
        }
        public static void ButtWorld()
        {
            Console.WriteLine("You look around and notice everything is butts.\n\nThe ground is butts...the clouds are butts...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("The ground is butts...\n\n");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("the clouds are butts...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("You realize that the air is unbreathable and must be mostly methane from all the farts.");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Everything turns dark as you fade into a fart coma...");
            Console.ReadKey();
            Console.Clear();
            Morty.MortyDies();
            Console.ReadKey();
            Console.Clear();
        }
        public static void TheCitadel()
        {
            Console.WriteLine("You are at the citadel");
            Console.ReadKey();
            Console.Clear();
            string decision = "Would you like to stay at the citadel or go somewhere else?";
            string[] portals = { "Portal somewhere else..", "Stay and enjoy the Rick overlords." };
            Menu portalMenu = new Menu(decision, portals);
            int selectedIndex = portalMenu.Run();
            switch (selectedIndex)
            {
                case 2:

                    break;
                case 0:



                    PortalGun.Portal();
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 1:
                    CitadelStay();
                    Console.ReadKey();
                    Console.Clear();
                    break;
            }
        }
        public static void HolographicSimulation()
        {
            Console.WriteLine("You are in a simulation");
            Console.ReadKey();
            Console.Clear();
            string decision = "Would you like to stay in the simulation forever or go somewhere else?";
            string[] portals = { "Portal somewhere else..", "Stay and...simulate?" };
            Menu portalMenu = new Menu(decision, portals);
            int selectedIndex = portalMenu.Run();
            switch (selectedIndex)
            {
                
                case 0:

                    

                    PortalGun.Portal();
                    Console.ReadKey();
                    Console.Clear();
                    break;
                    
                case 1:
                    SimulationStay();
                    Console.ReadKey();
                    Console.Clear();
                    break;
            }
        }
        public static void SimulationStay()
        {
            Console.WriteLine("everything is a simulation");
            Console.ReadKey();
            Console.Clear();
        }
        public static void CitadelStay()
        {
            Console.WriteLine("life at the citadel");
            Console.ReadKey();
            Console.Clear();
        }
        public static void ScreamStay()
        {
            Console.WriteLine("Death from screaming");
            Console.ReadKey();
            Console.Clear();
        }
        public static void CornStay()
        {
            Console.WriteLine("Corn");
            Console.ReadKey();
            Console.Clear();
        }
        public static void BlipsAndChitzStay()
        {
            Console.WriteLine("You stay at Blips and Chipz forever");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
