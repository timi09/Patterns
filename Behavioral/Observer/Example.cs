using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Behavioral.Observer
{
    class Example
    {
        public void Example1()
        {
            TemperatureSensor sensor = new TemperatureSensor();

            TemperatureMonitor monitor = new TemperatureMonitor();

            sensor.AddObserver(monitor);

            for (int i = 0; i < 10; i++)
            {
                sensor.setTemperature(20 + i);
                Thread.Sleep(1000);
            }
        }

        public void Example2()
        {
            TemperatureSensor sensor = new TemperatureSensor();

            TemperatureMonitor monitor = new TemperatureMonitor();

            TemperatureWarning warning = new TemperatureWarning(25, 15);

            sensor.AddObserver(monitor);
            sensor.AddObserver(warning);

            for (int i = 0; i < 10; i++)
            {
                sensor.setTemperature(20 + i);
                Thread.Sleep(1000);
            }

            for (int i = 0; i < 10; i++)
            {
                sensor.setTemperature(20 - i);
                Thread.Sleep(1000);
            }
        }
    }
}
