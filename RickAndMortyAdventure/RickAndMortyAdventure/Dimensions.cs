using System;
using System.Collections.Generic;
using System.Text;

namespace RickAndMortyAdventure
{
    class Dimensions
    {
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

                    PortalGun.PortalFluid(PortalGun.portalFluid);

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

                    PortalGun.PortalFluid(PortalGun.portalFluid);

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

                    PortalGun.PortalFluid(PortalGun.portalFluid);

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

                    PortalGun.PortalFluid(PortalGun.portalFluid);

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

                    PortalGun.PortalFluid(PortalGun.portalFluid);

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
