using System;

namespace TDDMicroExercises.TelemetrySystem
{
    public class TelemetryDiagnosticControls
    {
        private const string DiagnosticChannelConnectionString = "*111#";

        private readonly TelemetryClient _telemetryClient;
        private string _diagnosticInfo = string.Empty;

        public TelemetryDiagnosticControls(TelemetryClient telemetryclient)
        // An IOC container or caller will be responsible for providing this dependency via constructor injection
        {

            _telemetryClient = telemetryclient;
        }

        public string DiagnosticInfo
        {
            get { return _diagnosticInfo; }
            set { _diagnosticInfo = value; }
        }

        public void CheckTransmission()
        {
            _diagnosticInfo = string.Empty;

            _telemetryClient.Disconnect();

            int retryLeft = 3;
            while (_telemetryClient.OnlineStatus == false && retryLeft > 0)
            {
                _telemetryClient.Connect(DiagnosticChannelConnectionString);
                retryLeft -= 1;
            }

            if (_telemetryClient.OnlineStatus == false)
            {
                throw new Exception("Unable to connect.");
            }

            _telemetryClient.Send(TelemetryClient.DiagnosticMessage);
            _diagnosticInfo = _telemetryClient.Receive();
        }
    }
}