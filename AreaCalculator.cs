namespace AreaCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Площу якої фігури ви хочете отримати?");
            Console.WriteLine("(Квадрат, Круг, Прямокутник, Трикутник)");
            string choice = Console.ReadLine();

            if (choice.ToLower() == "квадрат")
            {
                Console.Write("Введіть розмір сторони: ");
                float side = float.Parse(Console.ReadLine());
                Console.WriteLine("Площа = " + (side * side));
            }
            else if (choice.ToLower() == "круг")
            {
                Console.Write("Введіть розмір радіуса: ");
                float r = float.Parse(Console.ReadLine());
                float pi = 3.14159f;
                Console.WriteLine("Площа = " + (pi * r * r));
            }
            else if (choice.ToLower() == "прямокутник")
            {
                Console.Write("Введіть розмір першої сторони: ");
                float a = float.Parse(Console.ReadLine());
                Console.Write("Введіть розмір другої сторони: ");
                float b = float.Parse(Console.ReadLine());
                Console.WriteLine("Площа = " + (a * b));
            }
            else if (choice.ToLower() == "трикутник")
            {
                Console.Write("Введіть розмір основи: ");
                float baseTri = float.Parse(Console.ReadLine());
                Console.Write("Введіть розмір висоти: ");
                float height = float.Parse(Console.ReadLine());
                Console.WriteLine("Площа = " + ((baseTri * height) / 2));
            }
            else
            {
                Console.WriteLine("Такої фігури немає в списку.");
            }
        }
    }
}
