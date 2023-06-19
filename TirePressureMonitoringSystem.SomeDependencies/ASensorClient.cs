using System;
namespace TDDMicroExercises.TirePressureMonitoringSystem.SomeDependencies
{
    public class ASensorClient
    {
        // A class with the only goal of simulating a dependency on Sensor
        // that has impact on the refactoring.

        private readonly Sensor _sensor;
        public ASensorClient(Sensor sensor)
        // An IOC container will be responsible for providing this dependency via constructor injection
        {
            _sensor = sensor;

        }

        private void CheckSensor()
        {
            double value = _sensor.PopNextPressurePsiValue();
            value = _sensor.PopNextPressurePsiValue();
            value = _sensor.PopNextPressurePsiValue();
            value = _sensor.PopNextPressurePsiValue();
        }
    }
}