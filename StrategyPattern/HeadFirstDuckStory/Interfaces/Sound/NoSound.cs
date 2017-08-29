using System;

namespace HeadFirstDuckStory
{
    public class NoSound : ISoundBehavior
    {
        public void makeSound()
        {
            Console.WriteLine("I'm making no sound");
        }
    }
}
