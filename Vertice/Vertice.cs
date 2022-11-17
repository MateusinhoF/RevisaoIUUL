namespace Exercicio02
{
    public class Vertice
    {
        private int x;
        private int y;

        public int X {
            get { return x; }
            private set { x = value; }
        }

        public int Y
        {
            get { return y; }
            private set { y = value; }
        }

        public Vertice(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
                
        public double distancia(Vertice vertice2)
        {
            double distancia = 0;
            double x = this.x - vertice2.x;
            double y = this.y - vertice2.y;

            distancia = Math.Pow(x, 2) - Math.Pow(y, 2);
            distancia = Math.Sqrt(distancia);

            return distancia;
        }

        public void move(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public override bool Equals(object? obj)
        {
            return obj is Vertice vertice &&
                this.x == vertice.x &&
                this.y == vertice.y;
        }

    }
}