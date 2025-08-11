using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX1
{
    public class TestStatistics
    {
        private int _count;
        private float _sum;
        private float _avg;
        private float _min;
        private float _max;

        public TestStatistics()
        {
            _count = 0;
            _sum = 0f;
            _avg = 0f;
            _min = float.MaxValue;
            _max = float.MinValue;
        }

        public void AddScore(float score)
        {
            if (score < 0 || score > 100)
                throw new ArgumentException("Score must be between 0 and 100.");

            _count++;
            _sum += score;
            _avg = _sum / _count;

            if (score < _min) _min = score;
            if (score > _max) _max = score;
        }

        public int Count => _count;
        public float Sum => _sum;
        public float Average => _avg;
        public float Min => _min;
        public float Max => _max;
    }
}
