﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._5__Tasks_
{
    internal class Subscribers
    {
        public class ThreeSubscriber
        {
            public void OnKeyPressed(object sender, KeyboardEventArgs button)
            {
                Console.WriteLine("ThreeSubscriber : Pressed Button is 3");
            }
        }

        public class FiveSubscriber
        {
            public void OnKeyPressed(object sender, KeyboardEventArgs button)
            {
                Console.WriteLine("FiveSubscriber : Pressed Button is 5");
            }
        }
    }



}