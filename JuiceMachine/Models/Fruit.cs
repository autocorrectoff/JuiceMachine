using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuiceMachine.Models
{
    public abstract class Fruit
    {
        public string Name { get; set; }
        public float Weight { get; set; }
        public bool IsRotten { get; set; }
        private readonly Random _random = new Random();

        protected Fruit(string name, float weight, bool isRotten)
        {
            this.Name = name;
            this.Weight = weight;
            this.IsRotten = isRotten;
        }

        public bool IsRottenCheck()
        {
            var rotten = _random.Next(1, 100);
            IsRotten = rotten < 20 ? true : false;
            return IsRotten;
        }
    }
}
