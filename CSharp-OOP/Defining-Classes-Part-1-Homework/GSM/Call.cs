using System;

namespace Phone
{
    class Call
    {
        private DateTime dateAndTime;
        private string dialedNumber;
        private int duration;

        public Call(string diledNumber, int duration)
        {
            this.DateAndTime = DateTime.Now;
            this.DialedNumber = diledNumber;
            this.Duration = duration;
        }

        public DateTime DateAndTime
        {
            get
            {
                return this.dateAndTime;
            }
            private set
            {
                this.dateAndTime = value;
            }
        }

        public string DialedNumber
        {
            get
            {
                return this.dialedNumber;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new NullReferenceException();
                }
                this.dialedNumber = value;
            }
        }

        public int Duration
        {
            get
            {
                return this.duration;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }
                this.duration = value;
            }
        }

        public override string ToString()
        {
            return String.Format("Date and Time: {0}Number {1}Duration: {2} seconds",
                this.DateAndTime, this.DialedNumber, this.Duration);       
        }
    }
}
