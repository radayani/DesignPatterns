using System;

namespace HeadFirstStarbucksCoffee
{
    // CONCRETE DECORATOR 
    public class Mocha : CondimentDecorator
    {
        Beverage bvg;

        public Mocha(Beverage bvg){
            this.bvg = bvg;
        }

        public override string getDescription(){
            return bvg.getDescription() + ", Mocha";
        }
        public override double cost(){
            return 0.20 + bvg.cost();
        }
    }
    
}