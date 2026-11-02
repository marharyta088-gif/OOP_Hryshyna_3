namespace TextModifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Введіть текст:");
            string text = Console.ReadLine();
            string resultText = "";

            for (int i = 0; i < text.Length; i++)
            {          
                int position = i + 1;

                if (position % 15 == 0)
                {
                    resultText += "?";
                }
                else if (position % 5 == 0)
                {
                    resultText += "9";
                }
                else if (position % 3 == 0)
                {
                    resultText += "X";
                }
                else
                {
                    resultText += text[i];
                }
            }

            Console.WriteLine("Результат: " + resultText);
        }
    }
}
