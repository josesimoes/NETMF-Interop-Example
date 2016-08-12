using Microsoft.SPOT;

namespace TestInteropMFConsoleApplication
{
    public class Program
    {
        public static void Main()
        {
            // testing cpu serial number
            string serialNumber = "";

            foreach (byte b in Eclo.STM32F4.Utilities.HardwareSerial)
            {
                serialNumber += b.ToString("X2");
            }

            Debug.Print("cpu serial number: " + serialNumber);

            // test complicated calculation
            Eclo.STM32F4.Math math = new Eclo.STM32F4.Math();
            double result = math.SuperComplicatedCalculation(11.12);

            Debug.Print("calculation result: " + result);
        }
    }
}
