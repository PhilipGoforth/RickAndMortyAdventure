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
        }
        public static void OpenPortal()
        {
                Random r = new Random();
                int portalSelect = r.Next(0, 9);
                switch (portalSelect)
                {
                    case 1:
                        Dimensions.BlenderDimension();
                        break;
                    case 2:
                        Dimensions.BlipsAndChitz();
                        break;
                    case 3:
                        Dimensions.CornUniverse();
                        break;
                    case 4:
                        Dimensions.MortysRoom();
                        break;
                    case 5:
                        Dimensions.ScreamingSun();
                        break;
                    case 6:
                        Dimensions.TheCitadel();
                        break;
                    case 7:
                        Dimensions.ButtWorld();
                        break;
                    case 8:
                        Dimensions.HolographicSimulation();
                        break;
                }
        }
    }
}
