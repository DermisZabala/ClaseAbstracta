using System;

namespace ClaseAbstracta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Canguro miCanguro = new Canguro("Hamel");
            miCanguro.Desplazamiento();
            Console.WriteLine();

            Mamifero miMamifero = new Mamifero("PORPOR");
            miMamifero.NombreAnimal();
            miMamifero.Desplazamiento();
            Console.WriteLine();

            Reptil miReptil = new Reptil("PEPE");
            miReptil.NombreAnimal();
            miReptil.Desplazamiento();


            Console.ReadKey();
        }
    }
    abstract class Animales
    {
        public abstract void NombreAnimal();

        public abstract void Desplazamiento();

        public void Respirar()
        {
            Console.WriteLine("Soy capaz de respirar");
        }
    }
    class Reptil: Animales
    {
        private string nombre;
        public Reptil(string nombre) 
        {
            this.nombre = nombre;
        }

        public override void NombreAnimal()
        {
            Console.WriteLine("El nombre del reptil es " + nombre);
        }

        public override void Desplazamiento()
        {
            Console.WriteLine("Me desplazo arrastrándome por el suelo");
        }
    }
    class Mamifero: Animales
    {
        private string nombre;
        public Mamifero(string nombre)
        {
            this.nombre = nombre;
        }

        public override void Desplazamiento()
        {
            Console.WriteLine("Modifícame");
        }

        public override void NombreAnimal()
        {
            Console.WriteLine("El nombre del mamífero es " + nombre);
        }
    }

    class Canguro: Mamifero
    {
        public Canguro(string nombreCanguro): base(nombreCanguro) { }

        public override void Desplazamiento()
        {
            Console.WriteLine("La manera en la que me desplazo es saltando");
        }
    }

}
