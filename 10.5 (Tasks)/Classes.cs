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
            if (consoleKey.Key == ConsoleKey.Home)
            {
                return;
            }

            // It`s number
            if (consoleKey.Key >= ConsoleKey.D0 && consoleKey.Key <= ConsoleKey.D9)
                DigitKeyPressed(this, consoleKey);


            switch (consoleKey.Key)
            {

                case ConsoleKey.D3:
                    {
                        ThreeKeyPressed(this, consoleKey);
                        break;
                    }

                case ConsoleKey.D5:
                    {
                        FiveKeyPressed(this, consoleKey);
                        break;
                    }

                default:
                    {
                        AnyKeyPressed(this, consoleKey);
                        break;
                    }
            }

        }

    }

    class KeyboardEventArgs : EventArgs
    {

        public ConsoleKey Key { get; set; }
    }


}
