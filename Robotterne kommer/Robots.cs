using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robotterne_kommer
{
    internal class Robots
    {
        //Instance variables
        private string model;
        private string color = "Hvid";
        private string chip;
        private bool wifi;
        private byte batterySize = 0;
        private bool battery;
        private byte wheels;
        private bool soap;



        //Encapsulation
        public string Model { get { return model; } }
        public string Color { get { return color; } }
        public string Chip { get { return chip; } }
        public bool Wifi { get { return wifi; } }
        public byte BatterySize { get { return batterySize; } }
        public bool Battery { get { return battery; } }
        public byte Wheels { get { return wheels; } }
        public bool Soap { get { return soap; } }

        //Konstruckters
        public Robots(string model)
        {
            Random rng = new Random();
            int choice = rng.Next(0, 2);
            this.chip = choice == 1 ? "RX54667" : "QT8339";
            this.model = model;
        }
        public Robots(string model, string color) : this(model)
        {
            this.color = color;
        }
        public Robots(string model, string color, bool wifi ) : this(model, color)
        {
            this.wifi = wifi;
        }
        public Robots(string model, string color, bool wifi, bool battery, byte batterySize, bool soap, byte wheels) : this(model, color, wifi)
        {
            this.battery = battery;
            this.batterySize = batterySize;
            this.soap = soap;
            this.wheels = wheels;
        }


    }
}
