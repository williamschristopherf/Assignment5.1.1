
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

Console.WriteLine(IsNumPalinDrome(121));
Console.WriteLine(IsNumPalinDrome(123451));
Console.WriteLine(IsNumPalinDrome(123454321));
Console.WriteLine(IsNumPalinDrome(-121));