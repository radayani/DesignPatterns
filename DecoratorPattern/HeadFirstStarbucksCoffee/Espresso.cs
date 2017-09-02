using System;

namespace HeadFirstStarbucksCoffee
{
    // CONCRETE COMPONENT
    public class Espresso : Beverage
    {
        public Espresso(){
            description = "Espresso";
        }
        
        public override double cost(){
            return 1.99;
        }

        public override string getDescription()
        {
            return "Espresso";
        }
    }
    
}