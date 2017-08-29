using System;

namespace HeadFirstDuckStory
{
    public class FlyWithWings : IFlyBehavior
    {
        public void fly(){
            Console.WriteLine("I can fly!");
        }
    }
}
