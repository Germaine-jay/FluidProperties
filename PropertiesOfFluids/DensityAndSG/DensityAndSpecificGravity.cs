using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesOfFluids.DensityAndSG
{
    public class DensityAndSpecificGravity
    {
        protected static double _mass, _volume;
        protected static double _volumeofliquid, _weightofliquid;

        public DensityAndSpecificGravity() { }
        public DensityAndSpecificGravity(double liquidWeight, double volume, double mass, double Volume)
        {
            _volumeofliquid = volume;
            _weightofliquid = liquidWeight;
            _mass = mass;
            _volume = Volume;

        }

        public virtual double Density()
        {
            return _mass / _volume;
        }
        public virtual double SpecificWeightofliquid()
        {
            return _weightofliquid / _volumeofliquid;
        }
        public virtual double Specificgravity() { return _weightofliquid / _volumeofliquid; }
    }

    public class MassDensity : DensityAndSpecificGravity
    {
        public MassDensity(double m, double v) : base(0, 0, m, v) { }
        public override double Density()
        {
            double MassDensity = _mass / _volume;
            return MassDensity;
        }
    }

    public class WeightDensity : DensityAndSpecificGravity
    {
        public WeightDensity(double m, double v) : base(0, 0, m, v) { }
        public override double Density()
        {
            double WeughtDensity = _mass * 9.81 / _volume;
            return WeughtDensity;
        }
    }

    public class SpecificWeight : DensityAndSpecificGravity
    {
        public SpecificWeight(double w, double v) : base(w, v, 0, 0) { }

        public override double SpecificWeightofliquid()
        {
            var specificweight = _weightofliquid / _volumeofliquid;
            return specificweight;
        }
    }

    public class SpecificVolume : DensityAndSpecificGravity
    {
        public SpecificVolume(double w, double v) : base(w, v, 0, 0) { }

        public override double SpecificWeightofliquid()
        {
            double specificweight = _weightofliquid / _volumeofliquid;
            double specificMass = specificweight * 1000 / 9.81;

            double specificVolume = 1 / specificMass;
            return specificVolume;
        }
    }

    public class SpecificGravity : DensityAndSpecificGravity
    {
        public SpecificGravity(double m, double v) : base(m, v, 0, 0) { }

        public override double SpecificWeightofliquid()
        {
            double specificweight = _weightofliquid / _volumeofliquid;
            double specificMass = specificweight * 1000 / 9.81;

            double specificVolume = 1 / specificMass;
            double specificGravity = specificVolume / 9.81;

            return specificGravity;
        }
    }

}
