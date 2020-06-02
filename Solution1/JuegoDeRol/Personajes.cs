using System;
using System.Collections.Generic;
using System.Text;

namespace JuegoDeRol
{
    public enum maximos
    {
        velocidad=10,destreza=5,fuerza=10,nivel=10,armadura=10
    }
    class Personajes
    {
        //==================Caracteristicas
        private int velocidad;
        private int destreza;
        private int fuerza;
        private int nivel;
        private int armadura;
        //==============Datos
        private string tipo;
        private string nombre;
        private string apodo;
        private DateTime fechaNacimiento;
        private int salud=100;
        //==================Caracteristicas
        public int Velocidad { get => velocidad; set => velocidad = value; }
        public int Destreza { get => destreza; set => destreza = value; }
        public int Fuerza { get => fuerza; set => fuerza = value; }
        public int Nivel { get => nivel; set => nivel = value; }
        public int Armadura { get => armadura; set => armadura = value; }
        //============Datos
        public string Tipo { get => tipo; set => tipo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apodo { get => apodo; set => apodo = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public int Salud { get => salud; set => salud = value; }

        int anios;
        public int edad()
        {
            anios=Convert.ToInt32((FechaNacimiento-new DateTime()).ToString("yyy"));
            return anios;
        }
    }
}
