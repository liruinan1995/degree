using System;
using System.Collections.Generic;

namespace Degree
{
  class Program
  {
    private static DailyTemperature[] data = new DailyTemperature[]
    {
        new DailyTemperature(HighTemp: 57, LowTemp: 30),
        new DailyTemperature(60, 35),
        new DailyTemperature(63, 33),
        new DailyTemperature(68, 29),
        new DailyTemperature(72, 47),
        new DailyTemperature(75, 55),
        new DailyTemperature(77, 55),
        new DailyTemperature(72, 58),
        new DailyTemperature(70, 47),
        new DailyTemperature(77, 59),
        new DailyTemperature(85, 65),
        new DailyTemperature(87, 65),
        new DailyTemperature(85, 72),
        new DailyTemperature(83, 68),
        new DailyTemperature(77, 65),
        new DailyTemperature(72, 58),
        new DailyTemperature(77, 55),
        new DailyTemperature(76, 53),
        new DailyTemperature(80, 60),
        new DailyTemperature(85, 66)
    };
    static void Main(string[] args)
    {
      var heatingDegreeDays = new HeatingDegreeDays(65, data);
      Console.WriteLine(heatingDegreeDays);

      var coolingDegreeDays = new CoolingDegreeDays(65, data);
      Console.WriteLine(coolingDegreeDays);
    }
  }
}
