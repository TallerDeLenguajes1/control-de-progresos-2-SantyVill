using System;

namespace JuegoDeRol
{
    class Program
    {
        static void Main(string[] args)
        {
            Personajes personaje= new Personajes();
            Random numran = new Random();
            personaje.Velocidad = numran.Next((int)maximos.velocidad + 1);
            personaje.Destreza = numran.Next((int)maximos.destreza + 1);
            personaje.Fuerza = numran.Next((int)maximos.fuerza+1);
            personaje.Nivel = numran.Next((int)maximos.nivel + 1);
            personaje.Armadura = numran.Next((int)maximos.armadura + 1);
            Console.WriteLine("Tipo de personaje: ");
            personaje.Tipo = Console.ReadLine();
            Console.WriteLine("Nombre: ");
            personaje.Nombre = Console.ReadLine();
            Console.WriteLine("Apodo: ");
            personaje.Apodo = Console.ReadLine();
            personaje.FechaNacimiento = new DateTime();
            personaje.FechaNacimiento.AddYears(-numran.Next(300)+1);
            Console.WriteLine("Caracteristicas del personaje. ");
            Console.WriteLine("Velocidad:"+personaje.Velocidad+"\nDestreza: "+personaje.Destreza+"\nFuerza: "+personaje.Fuerza);
            Console.WriteLine("Nivel: "+personaje.Nivel+"\nArmadura: "+personaje.Armadura);
            Console.WriteLine("Datos.");
            Console.WriteLine("Tipo: "+personaje.Tipo+"\nNombre: "+personaje.Nombre+"\nApodo: "+personaje.Apodo+"\nFecha de nacimiento: "+personaje.FechaNacimiento);
            Console.WriteLine("Edad: "+personaje.edad()+"\nSalud: "+personaje.Salud);
        }
    }
}
