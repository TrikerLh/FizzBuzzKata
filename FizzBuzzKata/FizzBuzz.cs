namespace FizzBuzzKata;

public class FizzBuzz
{
    public static string Print(int number)
    {
        var result = string.Empty;
        if (number % 3 == 0)
        {
            result = "Fizz";
        }
        if (number % 5 == 0)
        {
            result += "Buzz";
        }
        if (number % 3 != 0 && number % 5 != 0)
        {
            result = number.ToString();
        }
        return result;
    }
}