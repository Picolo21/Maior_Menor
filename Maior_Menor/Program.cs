public class Program
{
    private static void Main(string[] args)
    {
        List<double> list = new List<double>();

        for (int i = 0; i < 15; i++)
        {
            try
            {
                Console.Clear();
                Console.Write($"Digite o {i + 1}º número: ");
                double number = double.Parse(Console.ReadLine());
                list.Add(number);
            }
            catch (Exception e)
            {
                Console.Clear();
                Console.WriteLine(e.Message);
            }
        }

        Console.Clear();
        Console.WriteLine("Lista de números digitados:\n");
        list.ForEach(number =>  Console.WriteLine($"{number}"));
        Console.WriteLine();

        double maxNumber = CalculatesLargestNumber(list);
        double minNumber = CalculatesSmallestNumber(list);

        Console.WriteLine("O maior número é: " + maxNumber.ToString("F2"));
        Console.WriteLine("O menor número é: " + minNumber.ToString("F2"));
    }

    private static double CalculatesLargestNumber(List<double> list)
    {
        return list.Max();
    }

    private static double CalculatesSmallestNumber(List<double> list)
    {
        return list.Min();
    }
}