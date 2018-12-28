namespace Mediatr.Cqrs.Services
{
    public interface INumberService
    {
        bool Add(int number, string numericString);
        string GetNumericStringValue(int number);
    }
}