# About Package
FliuidProperties package aid and facilitates developers to execute calculations based on fluid properties inside their project. It employ the use of  fundermental properties such as force, weight, mass etc to facilitate calculations for properties such as density(mass and weight), specific weight, specific gravity, specific volume and viscosity(dynamic and kinematic) of fluids.

# Target Language
C#, F# and Visual Basic

# Version
version 1.0.0

# Prerequisites
Basic understanding of .NET NuGet packages, c# and Visual studio(Optional)

# Getting Started With the Package
There are more than one(1) ways to start using FluidProperties package
* Using the .NET CLI
* Using Visual Studio

# Using the .NET CLI
To install this package using the .NET CLI, run the following code:
```sh
    dotnet add package FluidProperties --version 1.0.0 
 ```
# Installation using Visual Studio
* Right-click on Project dependencies
* Select Nuget Packages Manager
* Click on Browse to search FliuidProperties 
* Finally click on install.

# How to use 
This package contains multiple methods that are able to calculate differnt properties of a fluid

##To calculate Density 
Hint: mass should be in kg and volume should be in m³
```sh
using PropertiesOfFluids.DensityAndSG
namespace UsingFluidPropertiesPackage
{
    internal class Program
    {
        static void Main(string[] args)
        {
	        var Density = CalculateFluidProperty.GetDensity(double mass, double volume)
            Console.Writeline(Density);
        }
    }
}
```

##To calculate Weight Density 
Hint: mass should be in kN and volume should be in m³
```sh
using PropertiesOfFluids.DensityAndSG
namespace UsingFluidPropertiesPackage
{
    internal class Program
    {
        static void Main(string[] args)
        {
	        var WetDensity = CalculateFluidProperty.GetWeightDensity(double mass, double volume)
            Console.Writeline(WetDensity);
        }
    }
}
```

##To calculate Specific weight
Hint: mass should be in kN and volume should be in m³
```sh
using PropertiesOfFluids.DensityAndSG
namespace UsingFluidPropertiesPackage
{
    internal class Program
    {
        static void Main(string[] args)
        {
	        var SpecificWeight = CalculateFluidProperty.GetSpecificWeight(double mass, double volume)
            Console.Writeline(SpecificWeight);
        }
    }
}
```

##To calculate Specific gravity
Hint: mass should be in kN and volume should be in m³
```sh
using PropertiesOfFluids.DensityAndSG
namespace UsingFluidPropertiesPackage
{
    internal class Program
    {
        static void Main(string[] args)
        {
	        var SpecificGravity = CalculateFluidProperty.GetSpecificGravity(double mass, double volume)
            Console.Writeline(SpecificWeight);
        }
    }
}
```
##To calculate Specific volume
Hint: mass should be in kN and volume should be in m³
```sh
using PropertiesOfFluids.DensityAndSG
namespace UsingFluidPropertiesPackage
{
    internal class Program
    {
        static void Main(string[] args)
        {
	        var SpecificGravity = CalculateFluidProperty.GetSpecificVolume(double mass, double volume)
            Console.Writeline(SpecificWeight);
        }
    }
}
```
