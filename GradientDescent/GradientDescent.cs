using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradientDescent
{
    public class GradientDescent
    {
        private Func<double, double> _function;
        private double[] _input;
        private double[] _output;
        
        public GradientDescent(Func<double, double> func, double[] input, double[] output)
        {
            _function = func;
            _input = input;
            _output = output;
        }

        private double getJFunction()
        {
            double sum = 0;
            for (int i = 0; i < _output.Length; i++)
            {
                sum += (_function.Invoke(_input[i]) - _output[i]) * (_function.Invoke(_input[i]) - _output[i]);
            }
            sum = sum / (2 * _output.Length);

            return sum;
        }
    }
}
