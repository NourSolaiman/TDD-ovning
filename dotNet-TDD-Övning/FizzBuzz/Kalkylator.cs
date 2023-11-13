namespace FizzBuzz
{
	public class Kalkylator
	{
		public static string FizzBuzzKalkyl(int number)
		{
			if(number % 3 == 0 && number % 5 == 0)
			{
				return "FizzBuzz";
			}
			else if (number % 3 == 0)
			{
				return "Fizz";
			}
			else if(number % 5 == 0)
			{
				return "Buzz";
			}
            else
            {
				return number.ToString();
            }
        }
        public void LogMessage(string message)
        {
            Console.WriteLine($"{message}");
        }

    }
}