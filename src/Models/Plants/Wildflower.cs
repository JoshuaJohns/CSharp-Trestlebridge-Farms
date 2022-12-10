using System;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Plants
{
    public class WildFlower : IResource, IPlowing, ISeedProducing
    {
        private int _seedsProduced = 40;
        public string Type { get; } = "Wildflower";

        public double Harvest()
        {
            return _seedsProduced;
        }

        public override string ToString()
        {
            return $"Wildflower. Yum!";
        }
    }
}