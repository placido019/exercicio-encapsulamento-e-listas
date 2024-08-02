using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_de_fixação_lista_e_encapsulamento
{
    internal class Funcionario
    {
        //Sempre a maiúscula primeiro na hora de construir o construtor
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Salario { get; private set; }

        public Funcionario(int id, string nome, double salario)
        {
            //Sempre o maiúsculo primeiro!
            Id = id;
            Nome = nome;
            Salario = salario;
        }

        public void AumentarSalario(double porcentagem)
        {
            Salario += (porcentagem * Salario) / 100;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Nome: {Nome}, Salário: {Salario}";
        }


    }
}
