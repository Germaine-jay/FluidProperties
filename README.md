# About Package
The FliuidProperties package aid and facilitates developers to execute calculations based on fluid properties inside their project. It employs fundamental properties such as force, weight, mass, etc to simplify accounting for properties such as density(mass and weight), specific weight, specific gravity, specific volume, and viscosity(dynamic and kinematic) of fluids.

# Target Language
C#, F# and Visual Basic

# Version
version 1.0.0

# Prerequisites
Basic understanding of .NET NuGet packages, c#, and Visual Studio(Optional)

# Getting Started With the Package
There are more than one(1) ways to start using the FluidProperties package
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
This package contains multiple methods that are able to calculate different properties of a fluids.

## To calculate the Density 
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

## To calculate Weight Density 
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

## To calculate Specific weight
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

## To calculate Specific gravity
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
## To calculate Specific volume
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
## To calculate Dynamic Viscosity
Hint: velocity should be in m/s thickness in mm and other vector parameters in m²
```sh
using PropertiesOfFluids.Viscosity
namespace UsingFluidPropertiesPackage
{
    internal class Program
    {
        static void Main(string[] args)
        {
	        var dynamicViscosity = CalculateFluidProperty.DynamicViscosity(double force, double area, double VelocityOfUpper, double VelocityOfLower, double thickness)
            Console.Writeline(dynamicViscosity);
        }
    }
}
```
## To calculate Kinematic Viscosity
Hint: velocity should be in m/s thickness in mm and other vector parameters in m²
```sh
using PropertiesOfFluids.Viscosity
namespace UsingFluidPropertiesPackage
{
    internal class Program
    {
        static void Main(string[] args)
        {
	        var kinematicViscosity = CalculateFluidProperty.KinematicViscosity(double force, double area, double VelocityOfUpper, double VelocityOfLower, double thickness, double specificgravity)
            Console.Writeline(kinematicViscosity);
        }
    }
}
```
# Contibutions
Contributions, complaints, and other feedback will be appreciated.
