internal class Program
{
    private static void Main(string[] args)
    {
        double value = 0;
        double max = 0;
        double min = 0;

        for (int i = 0; i <= 14; i++)
        {
            Console.Write($"Escreva o {i + 1}º número qualquer: ");
            value = double.Parse(Console.ReadLine());
            if ((max == 0) && (min == 0) && (i == 0))
            {
                max = value;
                min = value;
            }
            
            if ((max != 0) || (i > 0))
            {
                if (value > max)
                {
                    max = value;
                }
            }
            
            if ((min != 0) || (i > 0))
            {
                if (value < min)
                {
                    min = value;
                }
            }
        }

        Console.WriteLine();
        Console.WriteLine("O maior número é: " + max.ToString("F2"));
        Console.WriteLine("O menor número é: " + min.ToString("F2"));
    }
}