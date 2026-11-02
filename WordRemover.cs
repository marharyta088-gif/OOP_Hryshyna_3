namespace WordRemover
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Введіть речення:");
            string text = Console.ReadLine();

            Console.WriteLine("Введіть кількість слів для видалення (X):");
            int x = int.Parse(Console.ReadLine());

            string[] words = text.Split(' ');
            string resultText = "";

            for (int i = x; i < words.Length; i++)
            {
                resultText += words[i];

                if (i < words.Length - 1)
                {
                    resultText += " ";
                }
            }

            Console.WriteLine("Результат: " + resultText);
        }
    }
}
