using System;

namespace HeadFirstDuckStory
{
    public class FlyNoWings : IFlyBehavior
    {
        public void fly(){
            Console.WriteLine("I can't fly!");
        }
    }
}
