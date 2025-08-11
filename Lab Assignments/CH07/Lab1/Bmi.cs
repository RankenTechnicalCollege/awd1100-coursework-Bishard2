using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Bmi
    {
        private float _bmi;

        public Bmi(float weightInPounds, float heightInInches, float bmi, WeightCategory weightCategory)
        {
            _weightInPounds = weightInPounds;
            _heightInInches = heightInInches;
            _bmi = bmi;
            _weightCategory = weightCategory;
        }

        private float _weightInPounds;
        private float _heightInInches;
        private WeightCategory _weightCategory;

        public float WeightInPounds { get { return _weightInPounds; }}
        public float HeightInInches { get { return _heightInInches; }}
        public float BmiValue { get { return _bmi; }}
        public WeightCategory WeightCategory { get { return _weightCategory; }}
    }
}
