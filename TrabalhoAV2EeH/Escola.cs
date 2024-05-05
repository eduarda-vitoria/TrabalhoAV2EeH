using System;
using System.Collections.Generic;

namespace TrabalhoAV2EeH
{
    public class Escola
    {
        private ICollection<Aluno> alunos;

        public Escola()
        {
            alunos = new List<Aluno>();
        }

        // Adiciona um novo aluno à lista de alunos da escola
        public void AdicionarAluno(Aluno aluno)
        {
            // Verifica se o aluno já está na lista antes de adicionar
            if (!alunos.Contains(aluno))
            {
                alunos.Add(aluno);
                Console.WriteLine($"Aluno {aluno.Nome} adicionado com sucesso.");
            }
            else
            {
                Console.WriteLine($"Erro: O aluno {aluno.Nome} já está na lista.");
            }
        }

        // Remove um aluno da lista de alunos da escola, se encontrado
        public void RemoverAluno(Aluno aluno)
        {
            if (alunos.Contains(aluno))
            {
                alunos.Remove(aluno);
                Console.WriteLine($"Aluno {aluno.Nome} removido com sucesso.");
            }
            else
            {
                Console.WriteLine($"Erro: O aluno {aluno.Nome} não foi encontrado na lista.");
            }
        }

        // Busca um aluno na lista de alunos da escola pelo nome e retorna o aluno encontrado, se existir
        public Aluno BuscarAlunoPorNome(string nome)
        {
            foreach (var aluno in alunos)
            {
                if (aluno.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase))
                {
                    return aluno;
                }
            }
            Console.WriteLine($"Aluno {nome} não encontrado.");
            return null; // Retorna null se o aluno não for encontrado
        }
    }

    public class Aluno
    {
        public string Nome { get; }
        public int Idade { get; }

        public Aluno(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }
    }
}