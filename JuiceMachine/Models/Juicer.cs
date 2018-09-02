using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuiceMachine.Models
{
    public class Juicer
    {
        public Bowl Bowl { get; private set; }
        public Press Press { get; private set; }
        private Logger _logger = Logger.Instance;

        public Juicer(float maximumWeight)
        {
            Bowl = new Bowl(maximumWeight);
            Press = new Press();
        }

        public float ApplyPress()
        {
            float amount = Press.ApplyPress(Bowl.Fruits);
            if (amount > 30)
            {
                throw new CapacityOverloadException();
            }
            return amount;
        }

        public int AddFruit(Fruit fruit)
        {
            var random = new Random();
            var rand = random.Next(1, 100);
            if (rand < 70 && !fruit.IsRotten)
            {
                Bowl.Fruits.Add(fruit);
                _logger.Log($"{fruit.Name} added to the bowl");
            }
            else
            {
                _logger.Log($"{fruit.Name} not added to the bowl because it was rotten");
            }
            return Bowl.FruitAmount();
        }
    }
}
