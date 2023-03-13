using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaIFSP
{
    internal class Program
    {
        static int Menu()
        {
            Console.WriteLine("SAIR ------ 0");
            Console.WriteLine("CADASTRAR - 1");
            Console.WriteLine("LISTAR ---- 2");
            Console.WriteLine("REMOVER --- 3");
            Console.WriteLine("EDITAR ---- 4");
            return int.Parse(Console.ReadLine());
        }
        static void Main(string[] args)
        {
            int qtd = 0, opcao;
            Cliente[] vetCli = new Cliente[100];
            do {
                opcao = Menu();
                switch (opcao)
                {
                    case 0:
                        Console.WriteLine("Tchau!");
                        break;
                    case 1:
                        Console.WriteLine("Nome: ");
                        string nome = Console.ReadLine();
                        Console.WriteLine("Telefone: ");
                        string telefone = Console.ReadLine();
                        Console.WriteLine("Quer preencher e-mail " +
                            "e data de nascimento? 1 - Sim ou 0 - Não");
                        int escolha = int.Parse(Console.ReadLine());
                        if (escolha == 1)
                        {
                            Console.WriteLine("Email: ");
                            string email = Console.ReadLine();
                            Console.WriteLine("Data de nascimento: ");
                            DateTime nasc = Convert.ToDateTime(Console.ReadLine());
                            vetCli[qtd++] = new Cliente(
                                nome, telefone, email, nasc);
                        }
                        else
                        {
                            vetCli[qtd++] = new Cliente(
                                nome, telefone);
                        }
                        break;
                    case 2:
                        for (int i = 0; i < qtd; i++)
                        {
                            Console.WriteLine(vetCli[i].ToString());
                        }
                        break;
                    case 4:
                        Console.WriteLine("Digite o número de telefone: ");
                        string tel = Console.ReadLine();
                        for (int i = 0; i < qtd; i++)
                        {
                            if (vetCli[i].telefone == tel)
                            {
                                vetCli[i] = vetCli[qtd - 1];
                                qtd--;
                                break;
                            }
                        }
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }

            } while (opcao != 0);









            Console.ReadKey();
        }
    }
}
