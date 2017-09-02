using System;

namespace  HeadFirstStarbucksCoffee
{
    // ABSTRACT DECORATOR
    public abstract class CondimentDecorator : Beverage
    {
        public override string getDescription(){
            return "Condiment Decorator";
        }
        // public abstract new string getDescription();
        
    }
}