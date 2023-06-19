namespace TDDMicroExercises.TelemetrySystem.SomeDependencies
{
    public class TelemetryClientClient
    {
        // A class with the only goal of simulating a dependency on TelemetryClient
        // that has impact on the refactoring.

        public TelemetryClientClient(TelemetryClient telemetryclient)
        // An IOC container will be responsible for providing this dependency via constructor injection
        {
            ClientHelper.CheckClient(telemetryclient);

        }
    }
}