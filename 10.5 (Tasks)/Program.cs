using _10._5__Tasks_;

// eventArgs (button)
KeyboardEventArgs keyboardEventArgs = new KeyboardEventArgs();

// publisher
KeyboardManager keyboardManager = new KeyboardManager();

// subscriber
Subscribers.ThreeSubscriber threeSubscriber = new Subscribers.ThreeSubscriber();
Subscribers.FiveSubscriber fiveSubscriber = new Subscribers.FiveSubscriber();
Subscribers.DigitSubscriber digitSubscriber = new Subscribers.DigitSubscriber();
Subscribers.LogSubscriber logSubscriber = new Subscribers.LogSubscriber();


// agreement between publisher and subscriber  (subscription)
keyboardManager.ThreeKeyPressed += threeSubscriber.OnKeyPressed;
keyboardManager.ThreeKeyPressed += logSubscriber.OnKeyPressed;

keyboardManager.FiveKeyPressed += fiveSubscriber.OnKeyPressed;
keyboardManager.FiveKeyPressed += logSubscriber.OnKeyPressed;

keyboardManager.DigitKeyPressed += digitSubscriber.OnKeyPressed;
keyboardManager.DigitKeyPressed += logSubscriber.OnKeyPressed;

keyboardManager.AnyKeyPressed += logSubscriber.OnKeyPressed;



while (keyboardEventArgs.Key != ConsoleKey.Home)
{
    keyboardEventArgs.Key = Console.ReadKey().Key;
    keyboardManager.DefineKey(keyboardEventArgs);

}




