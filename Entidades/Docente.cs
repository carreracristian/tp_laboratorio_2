﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Docente : Personal
    {
        public double valorHora;
        //public int horasMensuales;

        /*public int HorasMensuales()
        {
            return this.horasMensuales;
        }*/
        public double ValorHora
        {
            get { return this.valorHora; }
            set { this.valorHora = value; }
        }

        public Docente(string nombre, string apellido, int dni,
                              bool femenino, DateTime horaEntrada,
                              DateTime horaSalida, double valorHora)//int horasMensuales)
                              : base(nombre, apellido, dni, femenino,
                                   horaEntrada, horaSalida)
        {
            this.valorHora = valorHora;
        }
        public override double CalcularSalario()
        {
            double horas = this.horaSalida.Subtract(this.horaEntrada).TotalHours;
            return this.valorHora * horas *20;
        }
        public override string ToString()
        {
            string sexo;
            if (femenino == true)
                sexo = "Femenino";
            else
                sexo = "Masculino";
            return $"{nombre} {apellido}\n Hora de Ingreso:{horaEntrada}\n " +
                $"Hora de Salida:{horaSalida}\n Sexo:{sexo}\n Valor de hora:{valorHora}\n " +
                $"DNI:{dni}\n Sueldo:{CalcularSalario()}";
        }
    }
}
