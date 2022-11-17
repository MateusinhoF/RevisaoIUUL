
namespace Exercicio01
{
    class Principal
    {

        static void Main(string[] args)
        {
            Piramide piramide;

            Console.WriteLine("digite um numero igual ou maior que 1");
            string linha = Console.ReadLine();

            int n = int.Parse(linha);

            piramide = new Piramide(n);
            piramide.desenha();
        }
                
    }
}
