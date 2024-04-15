using System;

namespace CadastroCliente
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cadastro de Cliente");
            Console.WriteLine();


            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Idade: ");
            int idade = int.Parse(Console.ReadLine());

            Console.Write("CPF: ");
            string cpf = Console.ReadLine();

            Console.Write("Telefone: ");
            string telefone = Console.ReadLine();

            Console.Write("Endereço: ");
            string endereco = Console.ReadLine();

            Console.Write("Estado Civil: ");
            string estadoCivil = Console.ReadLine();

            Console.Write("Nome da mãe: ");
            string nomeMae = Console.ReadLine();

            Console.Write("Nome do pai: ");
            string nomePai = Console.ReadLine();

            Console.Write("E-mail: ");
            string email = Console.ReadLine();

            Console.Write("Profissão: ");
            string profissao = Console.ReadLine();

            Console.Write("Gênero: ");
            string genero = Console.ReadLine();

            Console.Write("Nacionalidade: ");
            string nacionalidade = Console.ReadLine();

            Console.Write("Data de Nascimento (DD/MM/AAAA): ");
            DateTime dataNascimento = DateTime.Parse(Console.ReadLine());

            Console.Write("Altura (em metros): ");
            double altura = double.Parse(Console.ReadLine());

            Console.Write("Peso (em kg): ");
            double peso = double.Parse(Console.ReadLine());

            Console.Write("Tipo Sanguíneo: ");
            string tipoSanguineo = Console.ReadLine();



            Console.WriteLine("----agora voce está cadastrado----");
        }
    }
}

