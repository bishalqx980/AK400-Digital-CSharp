using LibreHardwareMonitor.Hardware;

namespace AK400_Digital
{
    internal class HardwareMonitor
    {
        private Computer computer;

        public HardwareMonitor()
        {
            computer = new Computer
            {
                IsCpuEnabled = true,
                //IsGpuEnabled = true
            };

            computer.Open();
        }

        public float getCpuTemp()
        {
            float cpuTemp = 0;

            foreach (IHardware hardware in computer.Hardware)
            {
                if (hardware.HardwareType == HardwareType.Cpu)
                {
                    hardware.Update();

                    foreach (ISensor sensor in hardware.Sensors)
                    {
                        if (sensor.SensorType == SensorType.Temperature)
                        {
                            if (sensor.Value.HasValue && sensor.Value.Value > 0)
                            {
                                cpuTemp = Math.Max(cpuTemp, sensor.Value.Value);
                            }
                        }
                    }
                }
            }

            return cpuTemp;
        }

        public float getCpuUsage()
        {
            float cpuUsage = 0;

            foreach (IHardware hardware in computer.Hardware)
            {
                if (hardware.HardwareType == HardwareType.Cpu)
                {
                    hardware.Update();

                    foreach (ISensor sensor in hardware.Sensors)
                    {
                        if (sensor.SensorType == SensorType.Load && sensor.Name == "CPU Total")
                        {
                            cpuUsage = sensor.Value ?? 0;
                        }
                    }
                }
            }

            return cpuUsage;
        }
    }
}
