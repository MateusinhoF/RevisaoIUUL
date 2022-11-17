using Exercicio02;

namespace Exercicio04
{
    public class Poligono
    {
        List<Vertice> vertices;

        public int qtdeVertices
        {
            get { return vertices.Count; }
        }

        public Poligono(List<Vertice> vertices) {
            if (vertices.Count < 3)
            {
                throw new ArgumentException("É necessário ao menos 3 vertices para formar um poligono");
            }
            this.vertices = vertices;
        }

        public bool addVertice(Vertice vertice)
        {
         
            foreach (Vertice v in vertices)
            {
                if (v.Equals(vertice))
                {
                    return false;
                }
            }

            vertices.Add(vertice);

            return true;
        }

        public void removeVertice(Vertice vertice) {
        
            if (vertices.Count == 3)
            {
                throw new ArgumentException("Não é possível remover o vertice pois o poligono ficara com menos de 3 vertices");
            }
            if (!vertices.Remove(vertice))
            {
                throw new ArgumentException("Não foi possível remover o vertice");
            }
        }

        public double perimetro()
        {
            double perimetro = 0;

            for (int numVertice = 0; numVertice < vertices.Count-1; numVertice++)
            {
                perimetro += vertices[numVertice].distancia(vertices[numVertice+1]);
            }

            return perimetro;
        }
    }
}