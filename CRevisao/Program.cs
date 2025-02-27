namespace CRevisao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double media;

            Console.WriteLine("Digite a primeira nota: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a segunda nota: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            media = (num1 + num2) / 2;

            if (media >= 7)
            {
                Console.WriteLine($"O aluno está aprovado com uma média de: {media} ");
            }
            else if (media < 5)
            {
                Console.WriteLine($"O aluno está reprovado com uma média de: {media}");
            }
            else
            {
                Console.WriteLine($"O aluno está de recuperação com uma média de: {media}");
            }
        }
    }
}
