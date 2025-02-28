namespace CREx003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro número");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o segundo número");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int maior = Math.Max(num1, num2);

            Console.WriteLine($"O número maior é: {maior}");
        }
    }
}
