namespace Exercicio05
{
    public class Intervalo
    {
        public DateTime horaInicial { get; private set; }
        public DateTime horaFinal { get; private set; }
        public TimeSpan duracao
        {
            get
            {
                return horaFinal - horaInicial;
            }
        }

        public Intervalo(DateTime horaInicial, DateTime horaFinal) {
        
            if (horaInicial > horaFinal)
            {
                throw new ArgumentException("Hora inicial não pode ser maior que hora final");
            }
            this.horaFinal = horaFinal;
            this.horaInicial = horaInicial;
        }

        public bool temIntersecao(Intervalo intervalo02)
        {
            if (intervalo02.horaInicial >= this.horaInicial &&
                intervalo02.horaInicial <= this.horaFinal) {
                return true;
            }
            if (intervalo02.horaFinal >= this.horaInicial &&
                intervalo02.horaFinal <= this.horaFinal)
            {
                return true;
            }

            return false;
        }

        public override bool Equals(object? obj)
        {
            return obj is Intervalo intervalo &&
                    this.horaInicial == intervalo.horaInicial &&
                    this.horaFinal == intervalo.horaFinal;
        }

    }

}