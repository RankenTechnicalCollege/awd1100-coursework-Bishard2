using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    internal class Job
    {
        public const double TRIP_FEE = 35.0;

        private string _description;
        private double _hoursToComplete;
        private double _hourlyFee;
        private double _totalFee;

        public Job(string description, double hoursToComplete, double hourlyFee)
        {
            _description = description;
            _hoursToComplete = hoursToComplete;
            _hourlyFee = hourlyFee;
            CalculateTotalFee();
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public double HoursToComplete
        {
            get { return _hoursToComplete; }
            set
            {
                _hoursToComplete = value;
                CalculateTotalFee();
            }
        }

        public double HourlyFee
        {
            get { return _hourlyFee; }
            set
            {
                _hourlyFee = value;
                CalculateTotalFee();
            }
        }

        public double TotalFee
        {
            get { return _totalFee; }
        }

        private void CalculateTotalFee()
        {
            _totalFee = (_hoursToComplete * _hourlyFee) + TRIP_FEE;
        }
    }
}
