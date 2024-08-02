using System;
using System.Globalization;
using System.Collections.Generic;
using Exercício_de_fixação_lista_e_encapsulamento;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;

            // Solicita ao usuário o número de funcionários a registrar
            Console.WriteLine("Quantos funcionários você gostaria de registrar?");
            int n = int.Parse(Console.ReadLine());

            List<Funcionario> ListaFuncionario = new List<Funcionario>();

            // Registra cada funcionário
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"#{i + 1}");

                int id;
                while (true)
                {
                    Console.WriteLine("Digite o ID:");
                    id = int.Parse(Console.ReadLine());

                    // Verifica se o ID já existe na lista
                    if (ListaFuncionario.Exists(x => x.Id == id))
                    {
                        Console.WriteLine("Id inválido, por gentileza insira outro.");
                    }
                    else
                    {
                        break;
                    }
                }

                Console.WriteLine("Digite o nome do funcionário:");
                string nome = Console.ReadLine();

                Console.WriteLine("Digite o salário do funcionário:");
                double salario = double.Parse(Console.ReadLine());

                // Adiciona o novo funcionário à lista
                ListaFuncionario.Add(new Funcionario(id, nome, salario));
            }
            while (true)
            {
                // Pergunta ao usuário se deseja aumentar o salário de alguém
                Console.WriteLine("Gostaria de aumentar o salário de alguém? (1 para S/ 2 para N)");
                 string input = Console.ReadLine();

                if (int.TryParse(input, out choice) && (choice == 1 || choice == 2))
                {
                    break;
                } else
                {
                    Console.WriteLine("Por favor, insira um dado válido");
                }
            }

            if (choice == 1)
            {
                // Solicita o ID do funcionário que receberá o aumento
                Console.WriteLine("Entre com o Id do funcionário que receberá aumento:");
                int ProcuraId = int.Parse(Console.ReadLine());

                // vazio será a referência para meu objeto, uma variável que aponta para meu objeto
                Funcionario vazio = ListaFuncionario.Find(x => x.Id == ProcuraId);

                if (vazio != null)
                {
                    Console.WriteLine($"Digite a porcentagem a ser aumentada do salário:");
                    double porcentagem = double.Parse(Console.ReadLine());

                    // vazio.AumentarSalario(porcentagem) chama o método AumentarSalario no objeto vazio,
                    // que é uma referência ao funcionário encontrado na lista.
                    vazio.AumentarSalario(porcentagem);

                    // Vazio trabalha como uma variável que direciona o dado inserido para a minha classe
                    // Funcionario, ou seja, vazio aponta para minha classe e indica que quero inserir o dado lá
                }
                else
                {
                    Console.WriteLine("Funcionário não encontrado");
                }
            }

            // Saída de dados
            Console.WriteLine();
            Console.WriteLine("Saída de dados:");

            // A variável pessoa armazena uma referência a cada objeto
            // Funcionario da lista ListaFuncionario em cada iteração.
            // Funcionario é minha classe criada, ou seja, o objeto aqui
            foreach (Funcionario pessoa in ListaFuncionario)
            {
                Console.WriteLine(pessoa); // Método ToString é chamado implicitamente aqui
            }
        }
    }
}