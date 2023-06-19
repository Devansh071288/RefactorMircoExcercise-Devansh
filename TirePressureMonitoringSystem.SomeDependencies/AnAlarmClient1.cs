using System;
namespace TDDMicroExercises.TirePressureMonitoringSystem.SomeDependencies
{
    public class AnAlarmClient1
    {
        // A class with the only goal of simulating a dependency on Alert
        // that has impact on the refactoring.

        private Alarm _anAlarm;

        public AnAlarmClient1(Alarm alarm)
        // An IOC container will be responsible for providing this dependency via constructor injection
        {
            _anAlarm = alarm;
            CheckAlarm();
        }

        private void CheckAlarm()
        {
            _anAlarm.Check();
            bool isAlarmOn = _anAlarm.AlarmOn;
        }

    }
}