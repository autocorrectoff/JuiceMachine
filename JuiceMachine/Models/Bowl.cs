using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuiceMachine.Models
{
    public class Bowl
    {
        public float Capacity { get; set; }
        public List<Fruit> Fruits { get; private set; }

        public Bowl(float capacity)
        {
            Capacity = capacity;
            Fruits = new List<Fruit>();
        }

        public void AddFruit(Fruit fruit)
        {
            var spaceLeft = fruit.Weight < CapacityLeft();
            if (!fruit.IsRottenCheck() && spaceLeft)
            {
                Fruits.Add(fruit);
                Logger.Instance.Log($"{fruit.Name} weighting {fruit.Weight} added to the bowl");
            }
        }

        private float CapacityLeft()
        {
            var sum = Fruits.Sum(n => n.Weight);
            return Capacity - sum;
        }

        public int FruitAmount()
        {
            return Fruits.Count;
        }

        public double Total()
        {
            return Fruits.Sum(n => n.Weight) * 0.4;
        }
    }
}
