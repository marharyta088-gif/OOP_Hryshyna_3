namespace ReverseNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Введіть ціле число: ");
            string input = Console.ReadLine();

            bool isNegative = false;
            string numStr = input;

            if (input[0] == '-')
            {
                isNegative = true;
                numStr = input.Substring(1, input.Length - 1);
            }

            string reversedStr = "";
            
            for (int i = numStr.Length - 1; i >= 0; i--)
            {
                reversedStr += numStr[i];
            }

            long result = long.Parse(reversedStr);

            if (isNegative)
            {
                result = -result;
            }

            Console.WriteLine("Результат: " + result);
        }
    }
}
