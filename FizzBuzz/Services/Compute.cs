namespace FizzBuzz.Services;

public class Compute
{
    private readonly FizzBuzzProcessor _processor;

    public Compute(FizzBuzzProcessor processor)
    {
        _processor = processor;
    }

    public void AfficherFizzBuzz()
    {
        for (int i = 1; i <= 100; i++)
        {
            Console.Write(_processor.Process(i) + " ");
        }
    }
}