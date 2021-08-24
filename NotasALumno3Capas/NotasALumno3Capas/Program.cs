using NotasALumno3Capas.Entidades;
using NotasALumno3Capas.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotasALumno3Capas
{
    class Program
    {
        static void Main(string[] args)
        {
            ClsNotas clsnotas = new ClsNotas();
            NClsnotas nclsnotas = new NClsnotas();


            clsnotas.Lab1 = 7.3;
            clsnotas.Parcial1 = 9.3;

            clsnotas.Lab2 = 8;
            clsnotas.Parcial2 = 8.9;

            clsnotas.Lab3 = 6.2;
            clsnotas.Parcial3 = 8.5;

            Console.WriteLine(nclsnotas.Periodo1(clsnotas));
            Console.WriteLine(nclsnotas.periodo2(clsnotas));
            Console.WriteLine(nclsnotas.periodo3(clsnotas));
            Console.WriteLine(nclsnotas.ciclo1(clsnotas));

            Console.ReadLine();
        } 
    }
}
