using System;

namespace HeadFirstDuckStory
{
    public class Squeak : ISoundBehavior
    {
        public void makeSound()
        {
            Console.WriteLine("I'm making squeak sound");
        }
    }
}
