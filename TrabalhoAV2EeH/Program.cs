using System;

namespace TrabalhoAV2EeH
{
    class Program
    {
        static void Main(string[] args)
        {
            Escola escola = new Escola();

            bool continuar = true;
            while (continuar)
            {
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1 - Adicionar aluno");
                Console.WriteLine("2 - Remover aluno");
                Console.WriteLine("3 - Buscar aluno por nome");
                Console.WriteLine("4 - Sair");

                int opcao;
                if (int.TryParse(Console.ReadLine(), out opcao))
                {
                    switch (opcao)
                    {
                        case 1:
                            Console.Write("Digite o nome do aluno: ");
                            string nome = Console.ReadLine();
                            Console.Write("Digite a idade do aluno: ");
                            if (int.TryParse(Console.ReadLine(), out int idade))
                            {
                                Aluno novoAluno = new Aluno(nome, idade);
                                escola.AdicionarAluno(novoAluno);
                            }
                            else
                            {
                                Console.WriteLine("Erro: A idade do aluno deve ser um número inteiro.");
                            }
                            break;
                        case 2:
                            Console.Write("Digite o nome do aluno a ser removido: ");
                            string nomeRemocao = Console.ReadLine();
                            Aluno alunoRemocao = escola.BuscarAlunoPorNome(nomeRemocao);
                            if (alunoRemocao != null)
                            {
                                escola.RemoverAluno(alunoRemocao);
                            }
                            else
                            {
                                Console.WriteLine($"Erro: O aluno {nomeRemocao} não foi encontrado na escola.");
                            }
                            break;
                        case 3:
                            Console.Write("Digite o nome do aluno a ser buscado: ");
                            string nomeBusca = Console.ReadLine();
                            Aluno alunoBusca = escola.BuscarAlunoPorNome(nomeBusca);
                            if (alunoBusca != null)
                            {
                                Console.WriteLine($"Aluno encontrado - Nome: {alunoBusca.Nome}, Idade: {alunoBusca.Idade}");
                            }
                            break;
                        case 4:
                            continuar = false;
                            break;
                        default:
                            Console.WriteLine("Opção inválida. Tente novamente.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Erro: A opção deve ser um número inteiro.");
                }

                Console.WriteLine();
            }
        }
    }
}