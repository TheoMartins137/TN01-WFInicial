internal class Program
{
    private static void Main(string[] args)
    {
        double[] valor = new double[6];
        string[] nome = new string[6];

        for (int i = 0; i < 6; i++)
        {
            Console.Write("Digite o nome do produto: ");
            nome[i] = Console.ReadLine();

            Console.Write("Digite o preço do produto: ");
            valor[i] = Convert.ToDouble(Console.ReadLine());

            if (valor[i] < valor[0])
            {
                valor[0] = valor[i];
                nome[0] = nome[i];
            }

        }
        Console.WriteLine($"O produto {nome[0]} é o mais barato, no valor de: {valor[0]}");
    }
}