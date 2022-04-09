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
            lista.Add(new Leon("Max"));
            
            foreach (var felino in lista)
            {
                Console.WriteLine("Dime tu nombre: " + felino.nombre);
                Console.WriteLine("Por favor has tu gracia: " + felino.HacerGracia());
            }

        }
    }

    public abstract class Mamifero
    {
        public Mamifero()
        {
            
        }
    }

    public abstract class Felino : Mamifero
    {
        public string nombre;
        public decimal MaximaVelocidadEnKmPorHora;

        public Felino(string _nombre)
        {
            this.nombre = _nombre;
        }

        public abstract string HacerGracia();
    }

    public class Leon : Felino
    {
        public Leon(string nombre) : base(nombre)
        {
            this.MaximaVelocidadEnKmPorHora = 70;
        }

        public override string HacerGracia()
        {
            return "Roar";
        }
    }

    public class Gato : Felino
    {

        public Gato(string nombre) : base(nombre)
        {
            this.MaximaVelocidadEnKmPorHora = 40;
        }

        public override string HacerGracia()
        {
            return "Miau";
        }

        public void Saltar()
        {
            
        }
    }

    public class Tigre : Felino
    {
        public Tigre(string nombre) : base(nombre)
        {
            this.MaximaVelocidadEnKmPorHora = 80;
        }

        public override string HacerGracia()
        {
            return "Rasguña";
        }
    }

    public class Chita : Felino
    {
        public Chita(string nombre) : base(nombre)
        {
            this.MaximaVelocidadEnKmPorHora = 120;
        }

        public override string HacerGracia()
        {
            return "Corre rápido";
        }
    }

    

}
