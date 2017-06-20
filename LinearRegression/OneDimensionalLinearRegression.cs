using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearRegression
{
    public class OneDimensionalLinearRegression
    {
        private double[] _sourceXData;
        private double[] _sourceYData;
        private double _xAverage;
        private double _yAverage;

        public OneDimensionalLinearRegression()
        {

        }

        public double[] SourceXData
        {
            get
            {
                return _sourceXData;
            }

            set
            {
                _sourceXData = value;
                double sum = 0;
                foreach(double element in _sourceXData)
                {
                    sum += element;
                }
                _xAverage = sum / _sourceXData.Length;
            }
        }

        public double[] SourceYData
        {
            get
            {
                return _sourceYData;
            }

            set
            {
                _sourceYData = value;
                double sum = 0;
                foreach (double element in _sourceYData)
                {
                    sum += element;
                }
                _yAverage = sum / _sourceYData.Length;
            }
        }

        public double XAverage
        {
            get
            {
                return _xAverage;
            }

        }

        public double YAverage
        {
            get
            {
                return _yAverage;
            }
        }

        public void getLinearEquation(out double a, out double b)
        {
            a = 0;
            b = 0;
            double sumA = 0;
            double sumB = 0;
            for(int i = 0; i < _sourceXData.Length; i++)
            {
                sumA += (_sourceXData[i] - _xAverage) * (_sourceYData[i] - _yAverage);
                sumB += (_sourceXData[i] - _xAverage) * (_sourceXData[i] - _xAverage);
            }
            b = sumA / sumB;
            a = _yAverage - b * _xAverage;            
        }

    }
}
