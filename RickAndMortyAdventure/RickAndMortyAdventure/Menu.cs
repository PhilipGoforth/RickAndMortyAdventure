using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace RickAndMortyAdventure
{
    class Menu
    {
        private int SelectedIndex;
        private string[] Options;
        private string Prompt;

        public Menu(string prompt, string[] options)
        {
            Prompt = prompt;
            Options = options;
            SelectedIndex = 0;

        }

        public void DisplayOptions()
        {
            WriteLine(Prompt);
            for(int i = 0; i< Options.Length; i++)
            {
                string currentOption = Options[i];
                WriteLine($"<<{currentOption}>>");
            }
        }
    }
}
