﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_concrete_dependency_injection.CSharp.Main
{
    public class Computer
    {
        public List<Game> installedGames = new List<Game>();

        public PowerSupply powerSupply;

        public Computer(PowerSupply powerSupply)
        {
            this.powerSupply = powerSupply;
        }

        public Computer(List<Game> preInstalled)
        {
            installedGames = preInstalled;
        }

        public void turnOn()
        {
            powerSupply.turnOn();
        }

        public void installGame(Game game)
        {
            this.installedGames.Add(game);
        }

        public string playGame(Game game)
        {
            if (this.installedGames.Contains(game))
            {
                return game.start();
            }
            else
            {
                return "Game not installed";
            }
        }
    }
}
