using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMICalculator
{
    class ManCalculator : AbstractCalculator
    {
        protected override int MaxBMI()
        {
            return 25;
        }

        protected override int MinBMI()
        {
            return 20;
        }
    }
}
