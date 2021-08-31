using System.Collections.Generic;
using System.Diagnostics;
using System.Management;

namespace AppleWirelessKeyboardCore.Services
{
    public static class ProcessMonitoringService
    {
        public static bool IsAllowed { get; private set; } = true;
        public static List<string> Programs { get; set; } = new ();

        static void Tick()
        {
            foreach (Process p in Process.GetProcesses())
                if (Programs.Contains(p.ProcessName))
                    IsAllowed = false;
        }

        static ManagementEventWatcher WatchForProcessStart(string processName)
        {
            string query = $@"SELECT TargetInstance
                  FROM __InstanceCreationEvent 
                  WITHIN  10
                  WHERE TargetInstance ISA 'Win32_Process'
                    AND TargetInstance.Name = '{processName}'";

            // The dot in the scope means use the current machine
            string scope = @"\\.\root\CIMV2";

            // Create a watcher and listen for events
            ManagementEventWatcher watcher = new ManagementEventWatcher(scope, query);
            watcher.EventArrived += ProcessStarted;
            watcher.Start();
            return watcher;
        }

        static ManagementEventWatcher WatchForProcessEnd(string processName)
        {
            string query = $@"SELECT TargetInstance
                  FROM __InstanceDeletionEvent
                  WITHIN  10
                  WHERE TargetInstance ISA 'Win32_Process'
                    AND TargetInstance.Name = '{processName}'";

            // The dot in the scope means use the current machine
            string scope = @"\\.\root\CIMV2";

            // Create a watcher and listen for events
            ManagementEventWatcher watcher = new ManagementEventWatcher(scope, query);
            watcher.EventArrived += ProcessEnded;
            watcher.Start();
            return watcher;
        }

        static void ProcessEnded(object sender, EventArrivedEventArgs e)
        {
            ManagementBaseObject targetInstance = (ManagementBaseObject) e.NewEvent.Properties["TargetInstance"].Value;
            string processName = targetInstance.Properties["Name"].Value.ToString() ?? "";
            Trace.WriteLine($"{processName} process ended");
        }

        static void ProcessStarted(object sender, EventArrivedEventArgs e)
        {
            ManagementBaseObject targetInstance = (ManagementBaseObject) e.NewEvent.Properties["TargetInstance"].Value;
            string processName = targetInstance.Properties["Name"].Value.ToString() ?? "";
            Trace.WriteLine($"{processName} process started");
        }
    }
}