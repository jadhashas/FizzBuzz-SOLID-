namespace FizzBuzz.Services;

public class FizzBuzzProcessor
{
    private readonly List<IFizzBuzzRule> _rules;

    public FizzBuzzProcessor()
    {
        _rules = new List<IFizzBuzzRule>
        {
            new FizzBuzzRule(),
            new FizzRule(),
            new BuzzRule(),
            new DefaultRule()
        };
    }

    public string Process(int number)
    {
        var rule = _rules.First(r => r.apply(number));
        return rule is DefaultRule defaultRule ? defaultRule.GetResult(number) : rule.GetResult(number);
    }
}