using System;

namespace RickAndMortyAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Game myGame = new Game();
            PortalGun.portalFluid = 5;
            
            myGame.Start();
            

        }
    }
}
