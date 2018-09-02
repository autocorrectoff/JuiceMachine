using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JuiceMachine.Models;

namespace JuiceMachine
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Juicer juicer = new Juicer(30);
            var rand = new Random();
            for (int i = 0; i < 100; i++)
            {
                bool isRotten = (rand.Next(1, 3) == 1) ? true : false;
                juicer.AddFruit(new Apple(isRotten, "Granny Smith"));
                juicer.ApplyPress();
            }
            Logger.Instance.Log($"{juicer.Bowl.Total()} of juice produced");
            Console.WriteLine($"{juicer.Bowl.Total()} of juice produced");

        }
    }
}
