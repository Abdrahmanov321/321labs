﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs.Game
{
    class ArrowUnit: Unit,IAttack
    {
        protected override int PowerCoef { get; } = 1;
        protected override int AggilityCoef { get; } = 4;
        protected override int DefenseCoef { get; } = 1;
        protected override int MaxHealthCoef { get; } = 10;

        private int _lvl = 1;
        private int _healthPoint;
        private int _exPoint;
        public override string Name { get; set; }
        public override int LVL { get => _lvl; set => Math.Max(value, 1); }
        public override int MaxHealth => Power * MaxHealthCoef;
        public override int Health { get => _healthPoint; set => _healthPoint = Math.Clamp(value, 0, MaxHealth); }
        public override int Power => LVL * PowerCoef;
        public override int Aggility => LVL * AggilityCoef;
        public override int Defense => LVL * DefenseCoef;
        public override int Exp { get => _exPoint; set => Math.Max(value, 0); }


        public ArrowUnit(string Name, int LVL) : base(LVL, Name) { }
        public void Damage(object obj)
        {
            if (obj is Unit u)
            {
                if (u.Health <= 0) return;
                u.GetDamage(Aggility);
                if (u.Health <= 0) Exp += u.LVL;
            }
        }

        public override void GetDamage(int Damage)
        {
            if (new Random().Next(Damage) > Aggility)
            {
                Health -= (Math.Max(Damage - Defense, 0));
            }
        }
    }
}
