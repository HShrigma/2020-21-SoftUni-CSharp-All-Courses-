﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FoodShortage
{
    public class Rebel : Entity, IBuyer
    {
        public Rebel(string name, int age, string group)
        {
            this.Name = name;
            this.Age = age;
            this.Group = group;
            this.Food = 0;
        }

        public int Food { get; set; }

        public void BuyFood()
        {
            this.Food += 5;
        }
    }
}
