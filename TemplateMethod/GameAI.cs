namespace TemplateMethod
{
    abstract class GameAI
    {
        public abstract void CollectResources();
        public abstract void BuildStructures();
        public abstract void BuildUnits();
        public abstract void Attack();

        public abstract void sendScouts(int position);
        public abstract void sendWarriors(int position);
    }
}