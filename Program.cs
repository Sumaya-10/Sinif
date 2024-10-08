//fibo

int num = 0;
int fib = 1;

int index = 0;
while (true)
{
    Console.Write(num);
    Console.Write(" ");

    fib = fib + num;
    num = fib - num;

    index = index + 1;

    if (index == 10)
    {
        break;
    }
}