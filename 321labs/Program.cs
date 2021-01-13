﻿using System;
using _321labs.LabGame.Base;
using _321labs.LabGame.Heroes;
using System.Numerics;

namespace _321labs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Leave hope behind all who enters here....");
            Warrior warrior1 = new Warrior(new Vector2(8, 8), 1, "Элезар", 100, 20, 1, 2, 20, 4, 24);
            Warrior warrior2 = new Warrior(new Vector2(-8, -8), 1, "Артур", 100, 20, 1, 2, 20, 4, 4);

            Console.WriteLine(Math.Sqrt(Math.Pow((warrior1.UnitPosition.X - warrior2.UnitPosition.X), 2) + Math.Pow((warrior1.UnitPosition.Y - warrior2.UnitPosition.Y), 2)));

            warrior1.ScanAround();

            warrior2.ScanAround();


            Console.WriteLine(warrior1.UnitPosition);
            Vector2 position = new Vector2(-9, -9);

            while (warrior1.UnitPosition != position)
            {
                warrior1.MoveToPoint(position);
                Console.WriteLine(warrior1.UnitPosition);
            } 

            
        }
    }
}
