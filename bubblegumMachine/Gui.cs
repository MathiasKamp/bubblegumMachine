using System;

namespace bubblegumMachine
{
    /// <summary>
    /// denne klasse består af 2 gui metoder
    /// </summary>
    class Gui
    {
        // denne metode kalder renderascii metoden og udskriver en menu
        public void RenderMenu()
        {
            Console.ForegroundColor = ConsoleColor.Green;

            RenderAscii();

            Console.WriteLine("1. withdraw a gum");
            Console.WriteLine("2. show gum count");
            Console.WriteLine("3. exit");

        }

        // denne metoder uskriver bubblegum machine i ascii art
        public void RenderAscii()
        {
            
            string title = @"            
                ______ _   _____________ _      _____ _____ _   ____  ___ 
                | ___ \ | | | ___ \ ___ \ |    |  ___|  __ \ | | |  \/  | 
                | |_/ / | | | |_/ / |_/ / |    | |__ | |  \/ | | | .  . | 
                | ___ \ | | | ___ \ ___ \ |    |  __|| | __| | | | |\/| | 
                | |_/ / |_| | |_/ / |_/ / |____| |___| |_\ \ |_| | |  | | 
                \____/ \___/\____/\____/\_____/\____/ \____/\___/\_|  |_/ 
                                                                          
                                                                          
                ___  ___  ___  _____  _   _ _____ _   _  _____            
                |  \/  | / _ \/  __ \| | | |_   _| \ | ||  ___|           
                | .  . |/ /_\ \ /  \/| |_| | | | |  \| || |__             
                | |\/| ||  _  | |    |  _  | | | | . ` ||  __|            
                | |  | || | | | \__/\| | | |_| |_| |\  || |___            
                \_|  |_/\_| |_/\____/\_| |_/\___/\_| \_/\____/    
            ";
            Console.WriteLine(title);
        }
    }
}