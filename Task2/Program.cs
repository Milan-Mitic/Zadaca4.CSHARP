namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter sentence: ");
            string sentenceInput = Console.ReadLine();

            string[] words = sentenceInput.Split(' ');

            Console.WriteLine("Words in the sentence:\n ");
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}