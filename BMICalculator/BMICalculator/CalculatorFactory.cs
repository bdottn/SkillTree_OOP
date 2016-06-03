namespace BMICalculator
{
    static class CalculatorFactory
    {
        public static ICalculator GetCalculator(Person person)
        {
            if (person.Gender == Gender.Man)
            {
                AbstractCalculator calculator = new ManCalculator();
                calculator.Weight = person.Weight;
                calculator.Height = person.Height;

                return calculator;
            }
            else
            {
                AbstractCalculator calculator = new WomanCalculator();
                calculator.Weight = person.Weight;
                calculator.Height = person.Height;

                return calculator;
            }
        }
    }
}