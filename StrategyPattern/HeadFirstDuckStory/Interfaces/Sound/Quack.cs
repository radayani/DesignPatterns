using System;

namespace HeadFirstDuckStory
{
    public class Quack : ISoundBehavior
    {
        public void makeSound()
        {
            Console.WriteLine("I'm making quack sound");
        }
    }
}
