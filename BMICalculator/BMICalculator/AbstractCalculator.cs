namespace BMICalculator
{
    abstract class AbstractCalculator : ICalculator
    {
        public double Height { get; set; }

        public double Weight { get; set; }

        protected abstract int MaxBMI();

        protected abstract int MinBMI();

        private double BMICalculator()
        {
            return this.Weight / (this.Height * this.Height);
        }

        public string Calculator()
        {
            var bmi = this.BMICalculator();

            if (bmi > this.MaxBMI())
            {
                return "太胖";
            }

            if (bmi < this.MinBMI())
            {
                return "太瘦";
            }

            return "適中";
        }
    }
}