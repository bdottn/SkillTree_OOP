using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMICalculator
{
    class WomanCalculator : AbstractCalculator
    {
        protected override int MaxBMI()
        {
            return 22;
        }

        protected override int MinBMI()
        {
            return 18;
        }
    }
}
