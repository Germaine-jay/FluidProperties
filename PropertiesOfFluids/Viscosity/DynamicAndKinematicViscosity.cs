using PropertiesOfFluids.DensityAndSG;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesOfFluids.Viscosity
{
    public class DynamicAndKinematicViscosity
    {
        protected double _thickness;
        protected double _VelocityOfUpper, _VelocityOfLower;
        protected double _Area, _Force;
        protected double _specificGravity;

        public DynamicAndKinematicViscosity() { }
        public DynamicAndKinematicViscosity(double force, double area, double VelocityOfUpper, double VelocityOfLower, double thickness, double specificGravity)
        {
            _VelocityOfUpper = VelocityOfUpper;
            _VelocityOfLower = VelocityOfLower;
            _Force = force;
            _Area = area;
            _thickness = thickness;
            _specificGravity = specificGravity;
        }
        public virtual double Viscosity() 
        {
            double velocity = _VelocityOfUpper - _VelocityOfLower;
            double sharestress = _Force / _Area;

            double dynamicviscosity = (sharestress * _thickness) / velocity;
            return dynamicviscosity;
        }
    }
    public class DynamicViscosity : DynamicAndKinematicViscosity
    {
        public DynamicViscosity(double f, double a, double vu, double vl, double th) : base(f, a, vu, vl, th,0) { }
        
        public override double Viscosity()
        {
            
            Console.WriteLine("Dynamic Viscosiy is {0} N.s/m²", base.Viscosity());
            return _thickness;
        }
    }
    public class KinematicViscosity : DynamicAndKinematicViscosity
    {
        public KinematicViscosity(double f, double a, double vu, double vl, double th, double sg) : base(f, a, vu, vl, th,sg) { }

        public override double Viscosity()
        {
            double Weightdensity = 0.98 * _specificGravity;
            double massdensity = Weightdensity / 0.98;

            double KinematicViscosity = base.Viscosity()/ massdensity;

            Console.WriteLine("Kinematic Viscosiy is {0} m²/s", KinematicViscosity);
            return KinematicViscosity;
        }
    }
}
