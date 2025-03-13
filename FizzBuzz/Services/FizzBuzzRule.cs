namespace FizzBuzz.Services;

public class FizzBuzzRule : IFizzBuzzRule
{
    public bool apply(int number) => number % 3 == 0 && number % 5 == 0;
    public string GetResult(int number) => "FizzBuzz";
}