using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuiceMachine.Models
{
    public class Apple : Fruit
    {
        public string Type { get; set; }
        

        public Apple(bool isRotten, string type) : base("Apple", SetRandomWeight(), isRotten)
        {
            Type = type;
            IsRottenCheck();
        }

        private static float SetRandomWeight()
        {
            var random = new Random();
            var randomWeight = random.Next(1, 4);
            var weight = (float)randomWeight;
            return weight;
        }

        
    }
}
