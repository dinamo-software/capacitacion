using System;

namespace POO_101
{
    class Program
    {
        static void Main(string[] args)
        {

            Figura circulo = new Figura(0, 1, 10);
            Figura circulo2 = new Figura(0, 1, 10);
            Figura triangulo = new Figura(3, 3, 10);
            Figura cuadrado = new Figura(4, 4, 10);
            Figura rectangulo = new Figura(4, 4, 10);

            Console.WriteLine(string.Format("Figura=circulo angulos={0}, lados={1}, superfice={2}", circulo.angulos, circulo.lados, circulo.CalcularSuperficie()));

            Console.WriteLine(string.Format("Figura=cuadrado angulos={0}, lados={1}, superfice={2}", cuadrado.angulos, cuadrado.lados, cuadrado.CalcularSuperficie()));

        }
    }

    public abstract class Figura
    {
        public int angulos;
        public int lados { get; private set; }
        public int alto;

        public Figura(int cant_angulos, int cant_lados, int alto)
        {
            this.angulos = cant_angulos;
            this.lados = cant_lados;
            this.alto = alto;
        }

        /// <summary>
        /// Por ahora solo calcular la del cuadrado
        /// </summary>
        /// <returns></returns>
        public int CalcularSuperficie()
        {
            return this.alto * this.alto;
        }

    }

    public class Circulo : Figura
    {
        public Circulo(int diametro) : base(0, 1, diametro)
        {
            
        }
    }
}
