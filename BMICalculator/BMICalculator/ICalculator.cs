
namespace BMICalculator
{
    interface ICalculator
    {
        double Height { get; set; }

        double Weight { get; set; }

        string Calculator();
    }
}