namespace FizzBuzz.Services;

public interface IFizzBuzzRule
{
    bool  apply(int number);
    string GetResult(int number);
}