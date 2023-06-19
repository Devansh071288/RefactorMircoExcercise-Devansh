using System;
namespace TDDMicroExercises.TelemetrySystem.SomeDependencies
{
    public class TelemetryDiagnosticControlsClient2
    {
        // A class with the only goal of simulating a dependency on TelemetryDiagnosticControls
        // that has impact on the refactoring.
        public TelemetryDiagnosticControlsClient2(TelemetryDiagnosticControls telemetrydiagctrl)
        // An IOC container or caller will be responsible for providing this dependency via constructor injection
        {
            ClientHelper.CheckDiagnostics(telemetrydiagctrl);
        }
    }
}