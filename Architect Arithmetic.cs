using System;

namespace ArchitectArithmetic
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine(Rect(2500, 1500));
      Console.WriteLine(0.5 * Circ(375));
      Console.WriteLine(Tri(750, 500));

      double totalArea = 4158393;
      double floorCost = 180;
      double totalCost = totalArea * floorCost;

      Console.WriteLine($"The floor plan costs: {totalCost} pesos");
      

    }

    public static double Rect(double length, double width)
    {
      return length * width;

    }

    static double Circ(double radius)
    {
      return Math.PI * Math.Pow(radius, 2);
    }

    static double Tri(double bottom, double height)
    {
      return 0.5 * bottom * height;
    }
  }
}
