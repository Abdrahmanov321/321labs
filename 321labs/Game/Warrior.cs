﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs.Game
{
    class Warrior : Hero, IUpDamage
    {
        public void UpDamage()
        {
            Console.WriteLine("Damage upper");
        }
    }
}
