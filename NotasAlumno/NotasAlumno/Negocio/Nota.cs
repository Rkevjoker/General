using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotasAlumno.Negocio
{
    class Nota
    {
        private double lab1;
        private double parcial1;
        private double periodo1;

        private double lab2;
        private double parcial2;
        private double periodo2;

        private double lab3;
        private double parcial3;
        private double periodo3;

        private double ciclo1;

        public Nota(double lab1, double parcial1, double lab2, double parcial2, double lab3, double parcial3)
        {
            this.lab1 = lab1;
            this.parcial1 = parcial1;
            this.lab2 = lab2;
            this.parcial2 = parcial2;
            this.lab3 = lab3;
            this.parcial3 = parcial3;

            periodo1 = (lab1 * 0.40) + (parcial1 * 0.60);
            periodo2 = (lab2 * 0.40) + (parcial2 * 0.60);
            periodo3 = (lab3 * 0.40) + (parcial3 * 0.60);
            ciclo1 = (periodo1 + periodo2 + periodo3) / 3;

        }

        public double Lab1 { get => lab1; set => lab1 = value; }
        public double Parcial1 { get => parcial1; set => parcial1 = value; }
        public double Periodo1 { get => periodo1; set => periodo1 = value; }
        public double Lab2 { get => lab2; set => lab2 = value; }
        public double Parcial2 { get => parcial2; set => parcial2 = value; }
        public double Periodo2 { get => periodo2; set => periodo2 = value; }
        public double Lab3 { get => lab3; set => lab3 = value; }
        public double Parcial3 { get => parcial3; set => parcial3 = value; }
        public double Periodo3 { get => periodo3; set => periodo3 = value; }
        public double Ciclo1 { get => ciclo1; set => ciclo1 = value; }

        public override string ToString()
        {
            return " primer periodo " + periodo1 + " segundo periodo " + periodo2 + " tercer periodo " + periodo3 + " promedio de ciclo " + ciclo1;
        }
    }
}
