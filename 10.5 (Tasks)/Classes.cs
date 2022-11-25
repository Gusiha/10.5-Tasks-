using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._5__Tasks_
{
    class KeyboardManager
    {

        public event EventHandler<KeyboardEventArgs> ThreeKeyPressed;
        public event EventHandler<KeyboardEventArgs> FiveKeyPressed;
        public event EventHandler<KeyboardEventArgs> DigitKeyPressed;
        public event EventHandler<KeyboardEventArgs> AnyKeyPressed;


        public void DefineKey(KeyboardEventArgs button)
        {
            Console.WriteLine($"\nYou pressed : {button.Key}");



            OnKeyPressed(button);
        }


        // This method is responsible for raising an event 
        protected virtual void OnKeyPressed(KeyboardEventArgs consoleKey)
        {
            switch (consoleKey.Key)
            {
                case ConsoleKey.D3:
                    ThreeKeyPressed(this, consoleKey);
                    break;

                case ConsoleKey.D5:
                    FiveKeyPressed(this, consoleKey);
                    break;

                default:
                    break;
            }

        }

    }

    class KeyboardEventArgs : EventArgs
    {
        public KeyboardEventArgs()
        {
            Console.WriteLine("Enter the key");
            Key = Console.ReadKey().Key;
        }
        public ConsoleKey Key { get; set; }
    }

    
}
