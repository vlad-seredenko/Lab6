using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    public class Tablet
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Memory { get; set; }
        public double Year { get; set; }
        public double SizeDisplay { get; set; }
        public bool Bluetooth { get; set; }
        public bool NFC { get; set; }
        public  Tablet()
        {
        }
        public Tablet(string brand, string model, string color, int memory,
            double year, double sizedisplay, bool bluetooth, bool nfc)
        {
            Brand = brand;
            Model = model;
            Color = color;
            Memory = memory;
            Year = year;
            SizeDisplay = sizedisplay;
            Bluetooth = bluetooth;
            NFC = nfc;
        }

    }
}
