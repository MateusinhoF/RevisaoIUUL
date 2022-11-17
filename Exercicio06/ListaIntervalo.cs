using Exercicio05;

namespace Exercicio06
{
    public class ListaIntervalo
    {
        List<Intervalo> listIntervalo;

        public ListaIntervalo() { }

        public ListaIntervalo(List<Intervalo> listIntervalo) {
        
            this.listIntervalo = listIntervalo;

        }

        public bool addIntervalo(Intervalo intervalo)
        {
            foreach (Intervalo intervaloDaList in listIntervalo)
            {
                if (intervaloDaList.temIntersecao(intervalo))
                {
                    return false;
                }
            }

            listIntervalo.Add(intervalo);

            return true;
        }

        public void imprimir()
        {
            listIntervalo = listIntervalo.OrderBy(i => i.horaInicial).ToList();

            listIntervalo.ForEach(intervalo => {
                Console.WriteLine("Data e hora inicial = "+intervalo.horaInicial);
            });
        }
    }
}