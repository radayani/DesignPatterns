using System;

namespace HeadFirstStarbucksCoffee
{
    // CONCRETE COMPONENT
    public class HouseBlend : Beverage
    {
        public HouseBlend(){
            description = "House Blend";
        }
        
        public override double cost(){
            return 0.89;
        }

        public override string getDescription()
        {
            return "House Blend";
        }
    }
    
}