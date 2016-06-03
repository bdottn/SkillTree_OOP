namespace BMICalculator
{
    static class CalculatorFactory
    {
        public static ICalculator GetCalculator(Person person)
        {
            if (person.Gender == Gender.Man)
            {
                ICalculator calculator = new ManCalculator();
                calculator.Weight = person.Weight;
                calculator.Height = person.Height;

                return calculator;
            }
            else
            {
                ICalculator calculator = new WomanCalculator();
                calculator.Weight = person.Weight;
                calculator.Height = person.Height;

                return calculator;
            }
        }
    }
}