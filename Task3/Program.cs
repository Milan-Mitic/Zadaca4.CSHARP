namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            int sumOfDigits = SumOfDigits(number);
            Console.WriteLine("Sum of digits: " +  sumOfDigits);
        }

        static int SumOfDigits(int number)
        {
            number = Math.Abs(number);
            int sum = 0;

            while (number != 0)
            {
                int digit = number % 10;
                sum += digit;  
                number /= 10;
            }

            return sum;
        }
    }
}