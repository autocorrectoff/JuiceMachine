using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuiceMachine.Models
{
    public class Press
    {
        public int Juice { get; set; }

        public Press()
        {
            Juice = 0;
        }

        public float ApplyPress(List<Fruit> fruits)
        {
            var random = new Random();
            var rand = random.Next(1, 100);
            var amount = 0f;
            if (rand < 30)
            {
                var total = fruits.Sum(f => f.Weight);
                amount = Convert.ToSingle(total);
                Logger.Instance.Log($"{amount} of juice squeezed");
            }
            return amount;
        }
    }
}
