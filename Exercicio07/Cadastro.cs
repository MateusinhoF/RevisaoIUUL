using System.Globalization;
using System.Text.RegularExpressions;

namespace Exercicio07
{
    public class Cadastro
    {

        public static void Main(String[] args)
        {
            string nome = null;
            long cpf = 0;
            DateTime dataNascimento = new DateTime();
            Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-BR", false);
            float rendaMensal = 0;
            char estadoCivil = 'S';
            int dependentes = 0;
            bool proxima = false;

            Console.WriteLine("Digite seu nome");
            while (!proxima)
            {
                string linha = Console.ReadLine();
                if(linha.Length > 5 && new Regex(@"[a-zA-Z]").IsMatch(linha))
                {
                    nome = linha;
                    proxima = true;
                }
                if(!proxima)
                {
                    Console.WriteLine("Digite seu nome corretamente");
                }
            }

            proxima = false;
            Console.WriteLine("Digite seu cpf sem pontuações");
            while (!proxima)
            {
                string linha = Console.ReadLine();
                if (linha.Length == 11 && new Regex(@"[0-9]").IsMatch(linha))
                {
                    cpf = long.Parse(linha);
                    proxima = true;
                }
                if (!proxima)
                {
                    Console.WriteLine("Digite seu cpf corretamente");
                }
            }

            proxima = false;
            Console.WriteLine("Digite sua data de nascimento no formato DD/MM/AAAA");
            while (!proxima)
            {
                string linha = Console.ReadLine();
                if (linha.Length == 10)
                {
                    dataNascimento = DateTime.Parse(linha);
                    
                    if (dataNascimento.AddYears(18) <= DateTime.Now)
                    {
                        proxima = true;
                    }
                }
                if (!proxima)
                {
                    Console.WriteLine("Precisa ser maior de 18 anos para concluir o cadastro");
                }
            }

            proxima = false;
            Console.WriteLine("Digite sua renda mensal separando com . o valor dos centavos exemplo 1850.50");
            while (!proxima)
            {
                string linha = Console.ReadLine();
                if (linha.Split('.')[1].Length > 1)
                {
                    rendaMensal = float.Parse(linha);
                    proxima = true;
                }
                if (!proxima)
                {
                    Console.WriteLine("Digite sua renda mensal corretamente");
                }
            }

            proxima = false;
            Console.WriteLine("Digite seu estado civil sendo C casado(a) S solteiro(a) V viuvo(a) D divorciado(a)");
            while (!proxima)
            {
                string linha = Console.ReadLine();
                string valido = "cCsSvVdD";
                if (linha.Length == 1 && valido.Contains(linha))
                {
                    estadoCivil = char.Parse(linha);
                    proxima = true;
                }
                if (!proxima)
                {
                    Console.WriteLine("Digite seu estado civil corretamente");
                }
            }

            proxima = false;
            Console.WriteLine("Digite o numero de dependentes");
            while (!proxima)
            {
                string linha = Console.ReadLine();
                if (new Regex(@"[0-9]").IsMatch(linha) && int.Parse(linha) >= 0 && int.Parse(linha) <= 10)
                {
                    dependentes = int.Parse(linha);
                    proxima = true;
                }
                if (!proxima)
                {
                    Console.WriteLine("Digite a quantidade correta de dependentes");
                }
            }

            Console.WriteLine("************ Dados Informados ****************");
            Console.WriteLine("Nome "+nome);
            Console.WriteLine("CPF " +cpf);
            Console.WriteLine("Data de Nascimento " +dataNascimento);
            Console.WriteLine("Renda Mensal " +rendaMensal);
            Console.WriteLine("Estado Civil " +estadoCivil);
            Console.WriteLine("Dependentes " +dependentes);
        }
    }
}