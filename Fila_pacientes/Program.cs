using System;

namespace Fila_pacientes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string resposta;
            Pessoa[] pessoa = new Pessoa[15];
            int contador = 0;

            do
            {
                Console.WriteLine("\nBom Dia! Como posso te ajudar hoje?\n" +
                    "1. Registrar paciente na fila\n" +
                    "2. Lista de pacientes registrados\n" +
                    "3. Registrar sintomas do paciente\n" +
                    "4. Redefinir informação do paciente\n" +
                    "q. Sair\n\nEscolha uma opção:");

                resposta = Console.ReadLine();

                switch (resposta)
                {

                    case "1":
                        if (contador < 15)
                        {
                            pessoa[contador] = new Pessoa();

                            Console.Write("Digite seu nome: ");
                            pessoa[contador].Nome = Console.ReadLine();

                            Console.Write("Digite sua idade: ");
                            pessoa[contador].Idade = int.Parse(Console.ReadLine());

                            Console.Write("Digite seu CPF: ");
                            pessoa[contador].CPF = Console.ReadLine();

                            Console.Write("Digite seu CEP: ");
                            pessoa[contador].CEP = int.Parse(Console.ReadLine());

                            Console.Write("Você possui alguma necessidade ou deficiência? (1.Sim / 2.Não): ");
                            string respPrioridade = Console.ReadLine();
                            pessoa[contador].Prioridade = (respPrioridade == "1") ? 2 : 1;

                            contador++;
                            Console.WriteLine("Paciente registrado com sucesso!");
                        }
                        else
                        {
                            Console.WriteLine("Fila cheia!");
                        }
                        break;


                    case "2":
                        Console.WriteLine("\nLista de pacientes por prioridade:");


                        for (int prioridadeAtual = 2; prioridadeAtual >= 1; prioridadeAtual--)
                        {
                            for (int i = 0; i < contador; i++)
                            {
                                if (pessoa[i].Prioridade == prioridadeAtual)
                                {
                                    Console.WriteLine($"{i + 1}) Nome: {pessoa[i].Nome}, Idade: {pessoa[i].Idade}, CPF: {pessoa[i].CPF}\n CEP: {pessoa[i].CEP}, Sintomas: {pessoa[i].Sintomas}");
                                }
                            }
                        }
                        break;


                    case "3":
                        Console.Write("Digite o número do paciente: ");
                        int indiceSintoma = int.Parse(Console.ReadLine()) - 1;

                        if (indiceSintoma >= 0 && indiceSintoma < contador)
                        {
                            Console.Write("Quais os sintomas? ");
                            pessoa[indiceSintoma].Sintomas = Console.ReadLine();
                            Console.WriteLine("Sintomas registrados!");
                        }
                        else
                        {
                            Console.WriteLine("Paciente não encontrado.");
                        }
                        break;


                    case "4":
                        Console.Write("Digite o número do paciente que deseja alterar: ");
                        int indice = int.Parse(Console.ReadLine()) - 1;

                        if (indice >= 0 && indice < contador)
                        {
                            Console.Write("Novo nome: ");
                            pessoa[indice].Nome = Console.ReadLine();

                            Console.Write("Nova idade: ");
                            pessoa[indice].Idade = int.Parse(Console.ReadLine());

                            Console.Write("Novo CPF: ");
                            pessoa[indice].CPF = Console.ReadLine();

                            Console.Write("Novo CEP: ");
                            pessoa[indice].CEP = int.Parse(Console.ReadLine());

                            Console.Write("Possui necessidade ou deficiência? (1.Sim / 2.Não): ");
                            string respPrioridade = Console.ReadLine();
                            pessoa[indice].Prioridade = (respPrioridade == "1") ? 2 : 1;

                            Console.WriteLine("Dados atualizados!");
                        }
                        else
                        {
                            Console.WriteLine("Paciente não encontrado.");
                        }
                        break;

                    
                    case "q":

                        break;

                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }

            } while (resposta != "q");
        }
    }
}
