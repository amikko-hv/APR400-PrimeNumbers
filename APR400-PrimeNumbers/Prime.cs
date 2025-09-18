using System.Diagnostics;

namespace APR400_PrimeNumbers;

public static class Prime
{
    /// <summary>
    /// Check if a number is a prime number
    /// </summary>
    /// <param name="number">Number to evaluate</param>
    /// <returns>True if prime otherwise false</returns>
    public static bool IsPrime(int number)
    {
        if (number < 2)
        {
            return false;
        }
        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }
        return true;
    }

    /// <summary>
    /// Synchronously count prime numbers and print the result to the console.
    /// </summary>
    /// <param name="numbers">Numbers to evaluate</param>
    public static void PrimeCounter(IEnumerable<int> numbers)
    {
        Console.WriteLine("Start synchronous prime counting...");
        
        var watch = Stopwatch.StartNew();
        int primeCount = 0;
        foreach (var n in numbers)
        {
            if (IsPrime(n))
            {
                primeCount++;
            }
    
        }
        watch.Stop();

        Console.WriteLine($"Found {primeCount} primes");
        Console.WriteLine($"Total time: {watch.ElapsedMilliseconds} ms");
    }

    /// <summary>
    /// Asynchronously count prime numbers in parallel and print the result to the console.
    /// </summary>
    /// <param name="numbers">Numbers to evaluate</param>
    public static async Task PrimeCounterAsync(IEnumerable<int> numbers)
    {
        // TODO: Count prime numbers in parallel.
    }
}