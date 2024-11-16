using System;

class Program
{
    // متد برای چک کردن اعداد اول
    static bool IsPrime(int number)
    {
        if (number <= 1) return false;
        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
                return false;
        }
        return true;
    }

    // متد برای چک کردن اعداد آینه‌ای
    static bool IsPalindrome(int number)
    {
        int original = number, reversed = 0;
        while (number > 0)
        {
            int digit = number % 10;
            reversed = reversed * 10 + digit;
            number /= 10;
        }
        return original == reversed;
    }

    static void Main()
    {
        Console.WriteLine("Please Select One of The Options:");
        Console.WriteLine("1. Identifying PrimeNumbers");
        Console.WriteLine("2.Identifying PalindromeNumbers");

        int choice = int.Parse(Console.ReadLine());

        if (choice == 1)
        {
            Console.Write("Please Enter a Number: ");
            int num = int.Parse(Console.ReadLine());
            if (IsPrime(num))
                Console.WriteLine($"{num} Is a Prime Number.");
            else
                Console.WriteLine($"{num} Is not a Prime Number.");
        }
        else if (choice == 2)
        {
            Console.Write("Please Enter a Number: ");
            int num = int.Parse(Console.ReadLine());
            if (IsPalindrome(num))
                Console.WriteLine($"{num}Is a Palindrome Number.");
            else
                Console.WriteLine($"{num} Is not a Palindrome Number.");
        }
        else
        {
            Console.WriteLine("The Choise is Wrong.");
        }
    }
}
