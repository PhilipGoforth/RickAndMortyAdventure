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
            

            

            string prompt = "Welcome to another Rick and Morty Adventure! What would you like to do?";
            string[] options = { "Play", "About", "Exit" };
            Menu mainMenu = new Menu(prompt, options);
            int selectedIndex = mainMenu.Run();

            WriteLine("Press any key to exit");
            ReadKey(true);
        }
    }
}
