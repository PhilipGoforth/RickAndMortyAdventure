using System;
using System.Collections.Generic;
using System.Text;

namespace RickAndMortyAdventure
{
    class PortalGun
    {
        public static int portalFluid{ get; set; }

        public static void Portal()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\n\t\t\t\t\t\tyou open a portal and jump in...");
            Console.ReadKey();
            Console.Clear();
            OpenPortal();
            Console.ReadKey();
            Console.Clear();
        }
        public static void OpenPortal()
        {

            if (PortalGun.portalFluid > 0)
            {
                Random r = new Random();
                int portalSelect = r.Next(0, 9);
                switch (portalSelect)
                {
                    case 1:
                        PortalGun.PortalFluid(PortalGun.portalFluid);
                        Console.ReadKey();
                        Console.Clear();
                        Dimensions.BlenderDimension();
                        break;
                    case 2:
                        PortalGun.PortalFluid(PortalGun.portalFluid);
                        Console.ReadKey();
                        Console.Clear();
                        Dimensions.BlipsAndChitz();
                        break;
                    case 3:
                        PortalGun.PortalFluid(PortalGun.portalFluid);
                        Console.ReadKey();
                        Console.Clear();
                        Dimensions.CornUniverse();
                        break;
                    case 4:
                        PortalGun.PortalFluid(PortalGun.portalFluid);
                        Console.ReadKey();
                        Console.Clear();
                        Dimensions.MortysRoom();
                        break;
                    case 5:
                        PortalGun.PortalFluid(PortalGun.portalFluid);
                        Console.ReadKey();
                        Console.Clear();
                        Dimensions.ScreamingSun();
                        break;
                    case 6:
                        PortalGun.PortalFluid(PortalGun.portalFluid);
                        Console.ReadKey();
                        Console.Clear();
                        Dimensions.TheCitadel();
                        break;
                    case 7:
                        PortalGun.PortalFluid(PortalGun.portalFluid);
                        Console.ReadKey();
                        Console.Clear();
                        Dimensions.ButtWorld();
                        break;
                    case 8:
                        PortalGun.PortalFluid(PortalGun.portalFluid);
                        Console.ReadKey();
                        Console.Clear();
                        Dimensions.HolographicSimulation();
                        break;
                }
            }
            else
            {
                Console.WriteLine("You are out of portal fluid!!");
                Console.ReadKey();
                Console.Clear();
            }
        }
            public static int PortalFluid(int portalFluid)
            {
            
            portalFluid--;
            Console.WriteLine($"Only {portalFluid} trips left with this amount of portal fluid...");
            return portalFluid;
             }
    }
}
