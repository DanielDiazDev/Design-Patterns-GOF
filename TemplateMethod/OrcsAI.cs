using System;

namespace TemplateMethod
{
    class OrcsAI : GameAI
    {
        int pos = 0;

        public override void Attack() => Console.WriteLine("OrcsAI Attack");
        public override void BuildStructures() => Console.WriteLine("OrcsAI BuildStructures");
        public override void BuildUnits() => Console.WriteLine("OrcsAI BuildUnits");
        public override void CollectResources() => Console.WriteLine("OrcsAI CollectResources");
        public override void sendScouts(int position) => pos++;
        public override void sendWarriors(int position) => pos++;
    }
}