namespace CREx006
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Quantas horas foram trabalhadas: ");
            int horas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Qual o valor da hora de trabalho: ");
            double valor = Convert.ToDouble(Console.ReadLine());

            double resultado = valor * horas;

            Console.WriteLine($"Tendo trabalhado {horas} e recebendo {valor} por hora, o {nome} recebeu: R${resultado:F2}");
        }
    }
}
