using System;

namespace RickAndMortyAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Game myGame = new Game();
            var myGun = new PortalGun();
            PortalGun.portalFluid = 5;
            myGame.Start();
            

        }
    }
}
