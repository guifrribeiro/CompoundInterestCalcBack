namespace CompoundInterestCalcBack.Services
{
    public interface ICompoundInterestService
    {
        double Calculate(double principal, double interestRate, int periods, double contribution);
    }
}