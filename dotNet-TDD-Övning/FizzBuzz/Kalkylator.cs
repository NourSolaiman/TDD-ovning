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
        public static void LogMessage(string message)
        {
            Console.WriteLine($"{message}");
        }
		public static void CheckIfNumber(string number)
		{
			try
			{
				var input = Int32.Parse(number);
				Console.WriteLine(input);

			}
			catch
			{
				throw new ArgumentException($"{number} is not a number");
			}


			/*
			if (input == 0)
			{
				Console.WriteLine($"{input}");
			}
			else
			{
				Console.WriteLine($"{input} is not a number");
			}
			*/
		}
    }
}