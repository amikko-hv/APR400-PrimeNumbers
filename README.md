# APR400-PrimeNumbers

Practice implementing asynchronous C# code that can run in parallell.

This console application counts the number of [prime numbers](https://en.wikipedia.org/wiki/Prime_number) present in a large array of integers.
The provided code does so in a synchronous fashion.

## Your Task

Run the application and note how long time the synchronous implementation takes.

Implement `PrimeCounterAsync`in a parallel fashion either by

- Using the Thread Parallel Library (TPL)
- Or manage threads manually with the `Thread` class

Try both if you have the time.

Note how long the async version takes.

## Think About

- How much faster is the multithreaded solution?
- Why is it faster?
- Why is this problem suitable to run in parallel?

## Notes

Does the execution of the synchronous implementation take too long?

- Try setting a **lower** value for the `count` variable in *Program.cs*

Does the execution of the synchronous implementation finish too fast?

- Try setting a **higher** value for the `count` variable in *Program.cs*
