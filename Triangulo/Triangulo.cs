using Exercicio02;

namespace Exercicio03
{
    public enum TipoTriangulo
    {
        EQUILATERO, ISOSCELES, ESCALENO
    }
    public class Triangulo
    {
        private Vertice vertice01;
        private Vertice vertice02;
        private Vertice vertice03;
        private double lado01;
        private double lado02;
        private double lado03;

        private double perimetro;
        public double Perimetro
        {
            get
            {
                perimetro = Vertice01.distancia(vertice02) +
                            Vertice02.distancia(vertice03) +
                            Vertice03.distancia(vertice01);

                return perimetro;
            }
            private set
            {
                perimetro = value;
            }
        }
        private TipoTriangulo tipo;
        public TipoTriangulo Tipo
        {
            get
            {
                tipo = TipoTriangulo.ESCALENO;
                if (lado01.Equals(lado02) && lado02.Equals(lado03) && lado03.Equals(lado01))
                {
                    tipo = TipoTriangulo.EQUILATERO;
                }
                if (lado01.Equals(lado02) && lado02.Equals(lado03) && !lado03.Equals(lado01) ||
                    lado01.Equals(lado02) && !lado02.Equals(lado03) && lado03.Equals(lado01) ||
                    !lado01.Equals(lado02) && lado02.Equals(lado03) && lado03.Equals(lado01))
                {
                    tipo = TipoTriangulo.ISOSCELES;
                }

                return tipo;
            }
            private set
            {
                tipo = value;
            }
        }
        private double area;
        public double Area
        {
            get
            {
                area = 0;
                double s = Perimetro / 2;

                area = s * (s - lado01) * (s - lado02) * (s - lado03);
                area = Math.Sqrt(area);

                return area;
            }
            private set
            {
                area = value;
            }
        }

        public Vertice Vertice01
        {
            get { return vertice01; }
            private set { vertice01 = value; }
        }
        public Vertice Vertice02
        {
            get { return vertice02; }
            private set { vertice02 = value; }
        }
        public Vertice Vertice03
        {
            get { return vertice03; }
            private set { vertice03 = value; }
        }

        public Triangulo(Vertice vertice01, Vertice vertice02, Vertice vertice03) {

            lado01 = vertice01.distancia(vertice02);
            lado02 = vertice02.distancia(vertice03);
            lado03 = vertice03.distancia(vertice01);

            if ((lado01 + lado02 <= lado03) ||
                (lado02 + lado03 <= lado01) ||
                (lado03 + lado01 <= lado02)){
                throw new Exception("Não é um triangulo");
            }

            Vertice01= vertice01;
            Vertice02= vertice02;
            Vertice03= vertice03;

        }

        public override bool Equals(object? obj)
        {
            return obj is Triangulo triangulo &&
                ((Vertice01.Equals(triangulo.Vertice01) &&
                  Vertice02.Equals(triangulo.Vertice02) &&
                  Vertice03.Equals(triangulo.Vertice03))
                ||
                 (Vertice01.Equals(triangulo.Vertice01) &&
                  Vertice02.Equals(triangulo.Vertice03) &&
                  Vertice03.Equals(triangulo.Vertice02))
                ||
                 (Vertice01.Equals(triangulo.Vertice02) &&
                  Vertice02.Equals(triangulo.Vertice01) &&
                  Vertice03.Equals(triangulo.Vertice03))
                ||
                 (Vertice01.Equals(triangulo.Vertice02) &&
                  Vertice02.Equals(triangulo.Vertice03) &&
                  Vertice03.Equals(triangulo.Vertice01))
                ||
                 (Vertice01.Equals(triangulo.Vertice03) &&
                  Vertice02.Equals(triangulo.Vertice01) &&
                  Vertice03.Equals(triangulo.Vertice02))
                ||
                 (Vertice01.Equals(triangulo.Vertice03) &&
                  Vertice02.Equals(triangulo.Vertice02) &&
                  Vertice03.Equals(triangulo.Vertice01))
                );
        }

    }
}