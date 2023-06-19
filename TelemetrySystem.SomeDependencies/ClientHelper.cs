using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDMicroExercises.TelemetrySystem.SomeDependencies
{
    public static class ClientHelper
    {
        public static void CheckClient(TelemetryClient telemetryclient)
        {
            if (!telemetryclient.OnlineStatus)
                telemetryclient.Connect("a connection string");

            telemetryclient.Send("some message");

            var response = telemetryclient.Receive();

            telemetryclient.Disconnect();
        }

        public static void CheckDiagnostics(TelemetryDiagnosticControls telemetrydiagctrl)
        {
            telemetrydiagctrl.CheckTransmission();

            var result = telemetrydiagctrl.DiagnosticInfo;
        }
    }
}