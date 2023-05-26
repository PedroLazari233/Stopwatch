using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Stopwatch
{
    internal class Stopwatch
    {
        private DateTime _startTime;
        private DateTime _endTime;

        public double Interval { get; set; }

        public DateTime StartTime
        {
            get { return _startTime; }
            set { _startTime = value; }
        }
        public DateTime EndTime
        {
            get { return _endTime; }
            set { _endTime = value; }
        }

        public void StartWatch()
        {
            _startTime = DateTime.UtcNow;
        }

        public void StopWatch()
        {
            _endTime = DateTime.UtcNow;
        }

        public void ProvidePeriod()
        {
            Interval = (EndTime - StartTime).TotalSeconds;
            _startTime = new DateTime(0);
            _endTime = new DateTime(0);
        }
    }
}
