using _10._5__Tasks_;

// eventArgs (button)
KeyboardEventArgs keyboardEventArgs = new KeyboardEventArgs();

// publisher
KeyboardManager keyboardManager = new KeyboardManager();

// subscriber
Subscribers.ThreeSubscriber threeSubscriber = new Subscribers.ThreeSubscriber();
Subscribers.FiveSubscriber fiveSubscriber = new Subscribers.FiveSubscriber();

// agreement between publisher and subscriber  (subscription)
keyboardManager.ThreeKeyPressed += threeSubscriber.OnKeyPressed;
keyboardManager.FiveKeyPressed += fiveSubscriber.OnKeyPressed;


while (keyboardEventArgs.Key != ConsoleKey.Home)
{
    keyboardEventArgs.Key = Console.ReadKey().Key;
    keyboardManager.DefineKey(keyboardEventArgs);

}




