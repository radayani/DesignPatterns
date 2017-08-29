namespace HeadFirstDuckStory
{
    class DuckSimulator
    {
        static void Main(string[] args)
        {
            var mallard = new MallarkDuck();
            mallard.setFlyBehavior(new FlyNoWings());
            mallard.setSoundBehavior(new NoSound());
            mallard.performSound();
            mallard.performFly();
        }
    }
}
