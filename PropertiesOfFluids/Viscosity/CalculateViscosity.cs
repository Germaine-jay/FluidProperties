using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesOfFluids.Viscosity
{
    public class CalculateViscosity
    {
        public static void DynamicViscosity(double force, double area, double VelocityOfUpper, double VelocityOfLower, double thickness)
        {
            DynamicAndKinematicViscosity viscosity = new DynamicViscosity(force, area, VelocityOfUpper, VelocityOfLower, thickness);
            viscosity.Viscosity();
        }

        public static void KinematicViscosity(double force, double area, double VelocityOfUpper, double VelocityOfLower, double thickness, double specificgravity)
        {
            DynamicAndKinematicViscosity viscosity = new KinematicViscosity(force, area, VelocityOfUpper, VelocityOfLower, thickness, specificgravity);
            viscosity.Viscosity();
        }
    }

    
}
