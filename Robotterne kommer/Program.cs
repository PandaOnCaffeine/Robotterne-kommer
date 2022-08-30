namespace Robotterne_kommer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string model;
            string color;
            bool wifi = false;
            string wifiYesNo;
            byte batterySize = 0;
            bool battery = false;
            bool soap = false;
            byte wheels = 0;

            Console.WriteLine("Hvilken model robot vil du købe");
            Console.WriteLine("Roomba, Vinduspudser, Dækskifter");
            model = Console.ReadLine().ToLower();


            Console.WriteLine("\r\nVælg farve");
            Console.WriteLine("Hvid, Rød, Blå, Grøn");
            color = Console.ReadLine().ToLower();


            Console.WriteLine("\r\nVil du ha wifi i robotten");
            Console.WriteLine("y for ja og n for nej");
            wifiYesNo = Console.ReadLine().ToLower();


            if (wifiYesNo == "y")
            {
                wifi = true;
            }
            else
            {
                wifi = false;
            }


            if (model == "roomba")
            {
                soap = true;
            }
            else if (model == "vinduspudser")
            {
                soap = true;
                Console.WriteLine("Hvor mange hjul vil du ha på");
                wheels = byte.Parse(Console.ReadLine());
            }
            else if (model == "dækskifter")
            {
                Console.WriteLine("Hvor mange hjul vil du ha på");
                wheels = byte.Parse(Console.ReadLine());
                if (color != "hvid")
                {
                    battery = false;
                }
                else
                {
                    battery = true;
                    Console.WriteLine("Hvor stort skal batteriet være fra 1 til 255");
                    batterySize = byte.Parse(Console.ReadLine());
                }
            }
            else
            {
                Console.WriteLine("!!!!!!!!!!!!!!!!!");
            }

            Robots robot = new Robots(model, color, wifi, battery, batterySize, soap, wheels);
            Console.WriteLine("");
            Console.WriteLine($"\r\nChip:{robot.Chip}\r\nModel: {robot.Model}\r\nColor: {robot.Color}\r\nWifi: {robot.Wifi}\r\nBattery: {robot.Battery}\r\nBatterySize: {robot.BatterySize}\r\nSoapThingy: {robot.Soap}\r\nWheels: {robot.Wheels}");
        }
    }
}