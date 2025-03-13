namespace FizzBuzz.Services;

public class DefaultRule: IFizzBuzzRule
{
    public bool apply(int number) => true;
    public string GetResult(int number) => number.ToString();
}