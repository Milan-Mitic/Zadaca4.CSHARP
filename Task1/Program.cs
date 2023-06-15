namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter one word: ");
            string wordInput = Console.ReadLine();
           

            if (wordInput.Length <= 5)
            {
                Console.WriteLine("The word is too short !!!");
            } else
            {
                string lastFiveChars = wordInput.Substring(wordInput.Length - 5);
                Console.WriteLine("Last 5 characters: " + lastFiveChars);
            }
            
        }
    }
}