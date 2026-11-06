internal class Program
{
    private static void Main(string[] args)
    {
        bool exercicio = true;
        while (exercicio)
        {
            Console.Clear();
            Console.WriteLine("Selecione uma opção: ");
            Console.WriteLine("1: Exercício Análise de Crédito");
            Console.WriteLine("2: Sair");

            int opcao = Convert.ToInt32(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    ExercicioAnaliseCredito();
                    break;

                case 2:
                    Console.WriteLine("Saindo...");
                    exercicio = false;
                    break;

                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }
            Console.WriteLine("Pressione uma tecla para continuar");
            Console.ReadKey();
        }

    } 

 public static void ExercicioAnaliseCredito()
    {
        Console.Write("Por favor solicite o valor do empréstimo: ");
        decimal valorEmprestimo = Convert.ToDecimal(Console.ReadLine());
        Console.Write("Digite a quantidade de parcelas desejadas: ");
        int numeroDeParcelas = Convert.ToInt32(Console.ReadLine());
        Console.Write("Digite a sua renda mensal: ");
        decimal rendaMensal = Convert.ToDecimal(Console.ReadLine());

        double resultado = Convert.ToDouble((rendaMensal * 30) / 100);
        double parcelaEmprestimo = Convert.ToDouble(valorEmprestimo / numeroDeParcelas);

        if (resultado >= parcelaEmprestimo)
        {
            Console.WriteLine("\n>>>Empréstimo autorizado");
        }
        else
        {
            Console.WriteLine("\n>>>Emprestimo não autorizado");
        }
        Console.WriteLine($"\nValor do Emprestimo: {valorEmprestimo}");
        Console.WriteLine($"Número de Parcelas: {numeroDeParcelas}");
        Console.WriteLine($"Valor da Parcela: {parcelaEmprestimo}");
        Console.WriteLine($"Valor da Renda Mensal: {rendaMensal}");
    }
}
