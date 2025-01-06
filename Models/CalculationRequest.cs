namespace CompoundInterestCalcBack.Models
{
    public class CalculationRequest
    {
        public double Principal { get; set; }
        public double InterestRate { get; set; }
        public int Periods { get; set; }
        public double Contribution { get; set; }
    }
}