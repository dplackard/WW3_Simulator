using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WW3_Library
{
    public class Weapons
    {
        private int _minDamage;

        public string Name { get; set; }
        public int MaxDamage { get; set; }
        public int Accuracy { get; set; }
        public int MinRange { get; set; }
        public int MaxRange { get; set; }
        public int HeadshotDamage { get; set; }
        public int MinDamage
        {
            get { return _minDamage; }
            set
            {
                _minDamage = value <= MaxDamage && value > 0 ? value : 1;
            }
        }
        public Weapons(string name, int accuracy, int minRange, int maxRange, int headshotDamage, int maxDamage, int minDamage)
        {
            Name = name;
            Accuracy = accuracy;
            MinRange = minRange;
            MaxRange = maxRange;
        }
    }
}
