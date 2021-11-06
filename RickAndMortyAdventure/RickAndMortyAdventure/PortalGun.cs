using System;
using System.Collections.Generic;
using System.Text;

namespace RickAndMortyAdventure
{
    class PortalGun
    {
        public static int portalFluid{ get; set; }

       public static int PortalFluid(int portalFluid)
        {
            
            portalFluid--;
            Console.WriteLine($"Only {portalFluid} trips left with this amount of portal fluid...");
            return portalFluid;
        }
    }
}
