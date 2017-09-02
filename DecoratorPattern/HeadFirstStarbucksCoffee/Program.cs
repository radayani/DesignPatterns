using System;

namespace HeadFirstStarbucksCoffee
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prepare Espresso
            Beverage bvg = new Espresso();
            Console.WriteLine(bvg.getDescription());

            // Prepare Double Mocha House Blend
            Beverage bvg2 = new HouseBlend();
            bvg2 = new Mocha(bvg2);
            bvg2 = new Mocha(bvg2);
            
            Console.WriteLine(bvg2.getDescription());
        }
    }
}
