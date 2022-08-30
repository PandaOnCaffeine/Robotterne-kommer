namespace Robotterne_kommer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Some variables to use later in the main method
            string model;
            string color;
            bool wifi = false;
            string wifiYesNo;
            byte batterySize = 0;
            bool battery = false;
            bool soap = false;
            byte wheels = 0;

            //Asks the user to input what model they want
            Console.WriteLine("Hvilken model robot vil du købe");
            Console.WriteLine("Roomba, Vinduspudser, Dækskifter");
            model = Console.ReadLine().ToLower();

            //User Chooses color of the robot
            Console.WriteLine("\r\nVælg farve");
            Console.WriteLine("Hvid, Rød, Blå, Grøn");
            color = Console.ReadLine().ToLower();

            //User Chooses if they want wifi or not
            Console.WriteLine("\r\nVil du ha wifi i robotten");
            Console.WriteLine("y for ja og n for nej");
            wifiYesNo = Console.ReadLine().ToLower();

            //Useing a if to check if the user wanted wifi or not
            if (wifiYesNo == "y")
            {
                wifi = true;
            }
            else
            {
                wifi = false;
            }

            //the first if checks if the users model input is valid
            if (model == "roomba")
            {
                //If its a roomba then it sets Soap to true so we know it has that soap thingy
                soap = true;
            }
            else if (model == "vinduspudser")
            {
                //If the model is WindowCleaner then it sets soap 
                //Asks user for the amount of wheels the robot has to have
                soap = true;
                Console.WriteLine("Hvor mange hjul vil du ha på");
                wheels = byte.Parse(Console.ReadLine());
            }
            else if (model == "dækskifter")
            {
                //If the model is TireChanger then it asks for amount of wheels
                Console.WriteLine("Hvor mange hjul vil du ha på");
                wheels = byte.Parse(Console.ReadLine());
                if (color != "hvid")
                {
                    //if the color is anything but white then it sets battery to false
                    battery = false;
                }
                else
                {
                    //if the color is White then it asks how big the batterySize should be from 1 to 255
                    battery = true;
                    Console.WriteLine("Hvor stort skal batteriet være fra 1 til 255");
                    batterySize = byte.Parse(Console.ReadLine());
                }
            }
            else
            {
                //This is for the people who types the model wrong in the input !!!!!!!!
                Console.WriteLine("!!!!!!!!!!!!!!!!!");
            }

            //Creates the objekt robot with the user defined variables
            Robots robot = new Robots(model, color, wifi, battery, batterySize, soap, wheels);

            //SKips a line
            Console.WriteLine("");
            //Writes out the robots infomation in the console window
            Console.WriteLine($"\r\nChip:{robot.Chip}\r\nModel: {robot.Model}\r\nColor: {robot.Color}\r\nWifi: {robot.Wifi}\r\nBattery: {robot.Battery}\r\nBatterySize: {robot.BatterySize}\r\nSoapThingy: {robot.Soap}\r\nWheels: {robot.Wheels}");
        }
    }
}