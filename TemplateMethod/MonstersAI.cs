using System;

namespace TemplateMethod
{
    class MonstersAI : GameAI
    {
        int pos = 0;

        public override void Attack() => Console.WriteLine("MonstersAI Attack");
        public override void BuildStructures() => Console.WriteLine("MonstersAI BuildStructures");
        public override void BuildUnits() => Console.WriteLine("MonstersAI BuildUnits");
        public override void CollectResources() => Console.WriteLine("MonstersAI CollectResources");
        public override void sendScouts(int position) => pos++;
        public override void sendWarriors(int position) => pos++;
    }
}