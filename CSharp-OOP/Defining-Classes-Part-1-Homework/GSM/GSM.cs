using System;
using System.Collections.Generic;

namespace Phone
{
    class GSM
    {
#region fields
        private string model;
        private string manufacturer;
        private double price;
        private string owner;
        private Battery battery;
        private Display display;
        private static readonly GSM iPhone4S = new GSM("4S", "iPhone", 400.00, "Gosho",
                 new Battery("iBattery", 100, 48, BatteryType.LiIon),
                 new Display(4.0f, 16000000));
#endregion

#region constructors

        public GSM(string model, string manufacturer)
            :this (model, manufacturer, 0.0, null, null, null)
        {
            this.model = model;
            this.manufacturer = manufacturer;
        }

        public GSM(string model, string manufacturer, Battery battery)
            : this(model, manufacturer, 0.0, null, battery, null)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.battery = battery;
        }

        public GSM(string model, string manufacturer, double price, string owner, Battery battery, Display display)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
            this.owner = owner;
            this.battery = battery;
            this.display = display;
        }
#endregion

#region properties
        public string Model
        {
            get
            {
                if (string.IsNullOrEmpty(this.model))
                {
                    throw new NullReferenceException();
                }
                return this.model;
            }
            set
            {
                if (string.IsNullOrEmpty(this.model))
                {
                    throw new ArgumentNullException();
                }
                this.model = value;
            }
        }

        public string Manufacturer
        {
            get
            {
                if (string.IsNullOrEmpty(this.manufacturer))
                {
                    throw new NullReferenceException();
                }
                return this.manufacturer;
            }
            set
            {
                this.manufacturer = value;
            }
        }

        public double Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value < 0.0)
                {
                    throw new ArgumentException();
                }
                this.price = value;
            }
        }

        public string Owner
        {
            get
            {
                if (string.IsNullOrEmpty(this.owner))
                {
                    throw new NullReferenceException();
                }
                return this.owner;
            }
            set
            {
                if (string.IsNullOrEmpty(this.owner))
                {
                    throw new ArgumentNullException();
                }
                this.owner = value;
            }
        }

        public Battery Battery
        {
            get
            {
                if (this.battery.Equals(null))
                {
                    throw new NullReferenceException();
                }
                return this.battery;
            }
            set
            {
                this.battery = value;
            }
        }

        public Display Display
        {
            get
            {
                if (this.display.Equals(null))
                {
                    throw new NullReferenceException();
                }
                return this.display;
            }
            set
            {
                this.display = value;
            }
        }

        public static GSM IPhone4S
        {
            get
            {
                return iPhone4S;
            }
        }

        public List<Call> CallHistory
        {
            get
            {
                return CallHistory;
            }
            set
            {
                CallHistory.AddRange(value);
            }
        }

#endregion

#region methods
        static void Main()
        {

        }

        public override string ToString()
        {
            return String.Format("{0} {1} {2} {3} {4} {5}", 
                this.Manufacturer, this.Model, 
                Environment.NewLine, this.Price,
                Environment.NewLine, this.Owner,
                Environment.NewLine, this.Battery.ToString(),
                Environment.NewLine, this.Display.ToString())
                .Trim();
        }

        public void AddCall(List<Call> range)
        {
            this.CallHistory.AddRange(range);
        }

        public void DeleteCall(int index, int count)
        {
            this.CallHistory.RemoveRange(index, count);
        }

        public void ClearHistory()
        {
            this.CallHistory.Clear();
        }

        public double TotalPrice(List<Call> allCalls, double price)
        {
            double total = 0;
            
            foreach (Call call in allCalls)
            {
                total += (call.Duration / 60) * price;
            }

            if (total == 0)
            {
                total = price;
            }

            return total;
        }

#endregion
       
    }
}
