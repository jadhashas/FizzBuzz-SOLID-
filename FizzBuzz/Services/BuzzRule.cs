namespace FizzBuzz.Services;

public class BuzzRule : IFizzBuzzRule
{
    public bool  apply(int number) => number % 5 == 0 && number % 3 != 0;
    public string GetResult(int number) => "Buzz";
}