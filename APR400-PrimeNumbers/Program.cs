using APR400_PrimeNumbers;

// Set how many integers to check if they are prime numbers
const int count = 10_000_000;

// Generate an array containing a sequence of integers 
var numbers = Enumerable.Range(0, count).ToArray();

// Count prime numbers sequentially
Prime.PrimeCounter(numbers);

// TODO: Count prime numbers in parallel
// Prime.PrimeCounterAsync(numbers).Wait();
