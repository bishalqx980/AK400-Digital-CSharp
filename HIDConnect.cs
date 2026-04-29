using HidSharp;

namespace AK400_Digital
{
    internal class HIDConnect
    {
        private HidDevice? device;
        private HidStream? stream;
        private byte[] BYTES = new byte[64];

        public bool Connect(int VendorID, int ProductID)
        {
            device = DeviceList.Local.GetHidDeviceOrNull(VendorID, ProductID);

            if (device != null && device.TryOpen(out stream))
            {
                return true;
            }
            return false;
        }

        public string GetDeviceInfo()
        {
            if (device == null)
                return "No device connected";

            return
                $"Manufacturer: {device.GetManufacturer()}\n" +
                $"Product: {device.GetProductName()}\n" +
                $"VID: {device.VendorID}\n" +
                $"PID: {device.ProductID}";
        }

        /// <summary>
        /// Send Data to the HID device // status = byte value. 19 for °C // 35 for °F // 76 for Usage
        /// </summary>
        /// <param name="data">floating value of usage/temp</param>
        /// <param name="status">byte value. 19 for °C // 35 for °F // 76 for Usage</param>
        public void SendData(float data, byte status, bool warning_alarm = false)
        {
            if (stream == null) return;

            int value = (int)data;
            byte alarm = 0;
            string valueStr = value.ToString("D3");

            if (warning_alarm)
            {
                alarm = 1;
            }

            // Bytes for device
            BYTES[0] = 16; // The "Magic" Report ID
            BYTES[1] = status; // 19 for °C // 35 for °F // 76 for Usage

            BYTES[2] = (byte)Math.Clamp(value / 10, 1, 10); // Status bar
            BYTES[3] = (byte)(valueStr[0] - '0'); // Hundreds
            BYTES[4] = (byte)(valueStr[1] - '0'); // Tens
            BYTES[5] = (byte)(valueStr[2] - '0'); // Ones
            BYTES[6] = alarm; // Alarm off (0 / 1)

            stream.Write(BYTES);
        }
    }
}
