namespace CompoundInterestCalcBack.Services
{
    public class CompoundInterestService : ICompoundInterestService
    {
        public double Calculate(double principal, double interestRate, int periods, double contribution)
        {
            double total = principal * Math.Pow(1 + interestRate, periods);

            for (int i = 1; i <= periods; i++)
            {
                total += contribution * Math.Pow(1 + interestRate, periods - i);
            }

            return total;
        }
    }
}