
 bool IsNumPalinDrome(int x)
{
    if (x < 0)
    {
        return false;
    }

        int original = x;
    int reversed = 0;

    while (x > 0)
    {
        int digit = x % 10;
        reversed = reversed * 10 + digit;
        x /= 10;
    }
    return original == reversed;
}
Console.WriteLine("Assignment 5.1.1");
Console.WriteLine();
Console.WriteLine($"121: {IsNumPalinDrome(121)}");
Console.WriteLine($"121: {IsNumPalinDrome(123451)}");
Console.WriteLine($"121: {IsNumPalinDrome(123454321)}");
Console.WriteLine($"-121: {IsNumPalinDrome(-121)}");
