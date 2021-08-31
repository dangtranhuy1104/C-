﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    class Tesla : ICar, IElectricCar
    {
        public Tesla() { }
        public Tesla(string model, string color, int battery)
        {
            this.Model = model;
            this.Color = color;
            this.Battery = battery;

        }

        public string Model
        {
            get;
            set;
        }

        public string Color
        {
            get;
            set;
        }

        public int Battery { get; set; }

        public string Start()
        {
            return "Engine start";
        }

        public string Stop()
        {
            return "Breaaak!";
        }

        public override string ToString()
        {
            return $"{Color} " + "Tesla " + $"{Model} " + "with " + $"{Battery} " + "Batteries" + "\n" +
                $"{Start()} " + "\n" + $"{Stop()}";
        }

    }
}
