using System.Reflection.Metadata.Ecma335;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your birthday: (dd-mm-yyyy) ");
            string birthdayInput = Console.ReadLine();

            DateTime birthday;
            if (DateTime.TryParse(birthdayInput, out birthday))
            {
                int age = AgeCalculator(birthday);
                Console.WriteLine("Your age is: " +  age);
            } else
            {
                Console.WriteLine("Date format is wrong!! Enter valid date format");
            }
        }

        public static int AgeCalculator(DateTime birthday)
        {
            DateTime today = DateTime.Now;
            int age = today.Year - birthday.Year;

            if(today < birthday.AddYears(age))
            {
                age--;
            }

            return age;
        }
    }
}