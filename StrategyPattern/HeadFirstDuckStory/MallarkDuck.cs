using System;

namespace HeadFirstDuckStory
{
    public class MallarkDuck: Duck
    {
        internal MallarkDuck(){
            sb = new Squeak();
            fb = new FlyWithWings();
        }

        override public void display(){
            Console.WriteLine("I'm a Mallard Duck");
        }
    }
}
