using System;
using System.Collections.Generic;

namespace POO_100
{
    class Program
    {
        static void Main(string[] args)
        {
            var lista = new List<Felino>();

            lista.Add(new Gato("Matute"));
            lista.Add(new Tigre("Kelogs"));
            lista.Add(new Chita("Linda"));

            foreach (var felino in lista)
            {
                Console.WriteLine("Nombre: " + felino.nombre);
            }

        }
    }

    public abstract class Mamifero
    {

    }

    public abstract class Felino : Mamifero
    {
        public string nombre;
        public decimal MaximaVelocidadEnKmPorHora;
        public Felino(string _nombre)
        {
            this.nombre = _nombre;
        }
    }

    public class Gato : Felino
    {

        public Gato(string nombre) : base(nombre)
        {
            this.MaximaVelocidadEnKmPorHora = 40;
        }
    }

    public class Tigre : Felino
    {
        public Tigre(string nombre) : base(nombre)
        {
            this.MaximaVelocidadEnKmPorHora = 80;
        }
    }

    public class Chita : Felino
    {
        public Chita(string nombre) : base(nombre)
        {
            this.MaximaVelocidadEnKmPorHora = 120;
        }
    }

    

}
