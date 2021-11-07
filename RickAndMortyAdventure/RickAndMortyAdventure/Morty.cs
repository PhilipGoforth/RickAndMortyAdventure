using System;
using System.Collections.Generic;
using System.Text;

namespace RickAndMortyAdventure
{
    class Morty
    {
        public int Health { get; set; }

        public static void MortyDies()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            string prompt = @"
                        
                        ▓██   ██▓ ▒█████   █    ██    ▓█████▄  ██▓▓█████ ▓█████▄ 
                         ▒██  ██▒▒██▒  ██▒ ██  ▓██▒   ▒██▀ ██▌▓██▒▓█   ▀ ▒██▀ ██▌
                          ▒██ ██░▒██░  ██▒▓██  ▒██░   ░██   █▌▒██▒▒███   ░██   █▌
                          ░ ▐██▓░▒██   ██░▓▓█  ░██░   ░▓█▄   ▌░██░▒▓█  ▄ ░▓█▄   ▌
                          ░ ██▒▓░░ ████▓▒░▒▒█████▓    ░▒████▓ ░██░░▒████▒░▒████▓ 
                           ██▒▒▒ ░ ▒░▒░▒░ ░▒▓▒ ▒ ▒     ▒▒▓  ▒ ░▓  ░░ ▒░ ░ ▒▒▓  ▒ 
                         ▓██ ░▒░   ░ ▒ ▒░ ░░▒░ ░ ░     ░ ▒  ▒  ▒ ░ ░ ░  ░ ░ ▒  ▒ 
                         ▒ ▒ ░░  ░ ░ ░ ▒   ░░░ ░ ░     ░ ░  ░  ▒ ░   ░    ░ ░  ░ 
                         ░ ░         ░ ░     ░           ░     ░     ░  ░   ░    
                         ░ ░                           ░                  ░      

                                     What would you like to do?
                               (Use arrow keys and Enter to select.)";
            string[] options = { "Play Again", "Exit" };
            Menu DeadMenu = new Menu(prompt, options);
            int selectedIndex = DeadMenu.Run();
            switch (selectedIndex)
            {
                case 0:
                    Game.RunChoice();
                    break;
                case 1:
                    Game.ExitGame();
                    break;
            }
        }
    }
}
