using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionario
{
    public enum NivelProfissional
    {
        Junior,
        Pleno,
        Senior
    }

    public class Funcionario
    {
        // Propriedades
        public string Nome { get; set; }
        public decimal Salario { get; set; }
        public NivelProfissional NivelProfissional { get; set; }
        public string CPF { get; set; }
        public IList<string> Habilidades { get; set; }

        // Construtor
        public Funcionario(string nome, decimal salario, string cpf, IList<string> habilidades)
        {
            if (!ValidarCPF(cpf))
            {
                throw new ArgumentException("CPF inválido");
            }

            if (salario < 2000)
            {
                NivelProfissional = NivelProfissional.Junior;
            }
            else if (salario >= 2000 && salario < 8000)
            {
                NivelProfissional = NivelProfissional.Pleno;
            }
            else
            {
                NivelProfissional = NivelProfissional.Senior;
            }

            if (habilidades == null || habilidades.Count < 3)
            {
                throw new ArgumentException("É necessário ter no mínimo 3 habilidades");
            }

            Nome = nome;
            Salario = salario;
            CPF = cpf;
            Habilidades = habilidades;
        }

        private bool ValidarCPF(string cpf)
        {

            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;
            int soma;
            int resto;
            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "");
            if (cpf.Length != 11)
                return false;
            tempCpf = cpf.Substring(0, 9);
            soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCpf = tempCpf + digito;
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
            return cpf.EndsWith(digito);
        }
    }



}
