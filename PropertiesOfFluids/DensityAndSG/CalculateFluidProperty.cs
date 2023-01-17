using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesOfFluids.DensityAndSG
{
    public class CalculateFluidProperty
    {
        public static void GetDensity(double m, double v)
        {
            DensityAndSpecificGravity density = new MassDensity(m,v);
            density.Density();
        }

        public static void GetWeightDensity(double m, double v)
        {
            DensityAndSpecificGravity weightdensity = new WeightDensity(m, v);
            weightdensity.Density();
        }

        public static void GetSpecificWeight(double m, double v)
        {
            DensityAndSpecificGravity weightdensity = new SpecificWeight(m, v);
            weightdensity.SpecificWeightofliquid();
        }

        public static void GetSpecificGravity(double m, double v)
        {
            DensityAndSpecificGravity specificGravity = new SpecificGravity(m, v);
            specificGravity.Specificgravity();
        }

        public static void GetSpecificVolume(double m, double v)
        {
            DensityAndSpecificGravity specificGravity = new SpecificVolume(m, v);
            specificGravity.SpecificWeightofliquid();
        }
    }
}
