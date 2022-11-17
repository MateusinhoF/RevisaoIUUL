namespace Exercicio01
{

    public class Piramide
    {
        private int n;

        public int N
        {
            get { return n; }

            set { 
                if (value <= 0)
                    throw new ArgumentOutOfRangeException("o valor de N dever ser maior ou igual a 1");
                n = value; 
            }
        }
        public Piramide(int n)
        {
            this.N = n;

        }

        public void desenha()
        {
            int aux = n;
            int crescente = 1;
            while (aux > 0)
            {
                string linha = "";
                for (int i = 0; i < aux; i++)
                {
                    linha+= " ";
                }
                for (int i = 1; i <= crescente; i++)
                {
                    linha += i;
                }
                for (int i = crescente-1; i >= 1; i--)
                {
                    linha += i;
                }
                Console.WriteLine(linha);
                crescente++;
                aux--;
            }
            
        }
    }
}