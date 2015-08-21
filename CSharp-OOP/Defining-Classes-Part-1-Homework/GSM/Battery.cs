using System;

namespace Phone
{
    public enum BatteryType  
    {
        LiIon, 
        NiMH, 
        NiCd,
        LiPo
    }

    internal class Battery
    {
#region fields
        private string model;
        private int hoursIdle;
        private int hoursTalk;
        private BatteryType batteryType;
#endregion

#region constructors
        public Battery(string model, BatteryType battery)
            :this(model, 0, 0, battery)
        {
            this.model = model;
        }

        public Battery(string model, int hoursIdle, int hoursTalk, BatteryType batteryType)
        {
            this.model = model;
            this.hoursIdle = hoursIdle;
            this.hoursTalk = hoursTalk;
            this.batteryType = batteryType;
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

        public int HoursIdle
        {
            get
            {
                return this.hoursIdle;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException();
                }

                this.hoursIdle = value;
            }
        }

        public int HoursTalk
        {
            get
            {
                return this.hoursTalk;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException();
                }

                this.hoursTalk = value;
            }
        }

        public BatteryType BatteryType
        {
            get
            {
                return this.batteryType;
            }
            private set
            {
                this.batteryType = value;
            }
        }
#endregion

#region methods
        
#endregion
    }
}
