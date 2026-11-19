using System;
using System.Collections.Generic;
using System.Text;

namespace Homework15
{
    internal class Player
    {
        public Player(string name, int score, bool isActive)
        {
            Name = name;
            Score = score;
            IsActive = isActive;
        }

        public string Name { get; set; }
        public int Score { get; set; }

        public bool IsActive { get; set; }

        public override string? ToString()
        {
            return $"{Name} - {Score} - {(IsActive ? "Active" : "Inactive")}";
        }
    }
}
