using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpleadoSalarios
{
    public class Empleado
    {
        private string nombre; //variables
        private string apellido;
        private string telefono;
        private int horas;
        private double subsidio;
        private double eps;
        private double afp;
        private double devengado;
        private double arl;
        private double salario;

        private double sena; //variables datagrid1
        private double icbf;
        private double cajacomp;
        private double salud;
        private double pension;
        private double afili;


        public string Nombre
        {
            get { return nombre; } // Getter: devuelve el valor actual del nombre
            set { nombre = value; } // Setter: asigna un nuevo valor al nombre
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public int Horas
        {
            get { return horas; }
            set { horas = value; }
        }

        public double Subsidio
        {
            get { return subsidio; }
            set { subsidio = 162000; }
        }

        public double EPS
        {
            get { return eps; }
            set { eps = value; }
        }

        public double AFP
        {
            get { return afp; }
            set { afp = value; }
        }

        public double Devengado
        {
            get { return devengado; }
            set { devengado = value; }
        }

        public double ARL
        {
            get { return arl; }
            set { arl = value; }
        }

        public double Salario
        {
            get { return salario; }
            set { salario = value; }
        }
        //Otro datagrid
        public double Sena
        {
            get { return sena; }
            set { sena = value; }
        }

        public double ICBF
        {
            get { return icbf; }
            set { icbf = value; }
        }

        public double CajaComp
        {
            get { return cajacomp; }
            set { cajacomp = value; }
        }

        public double Salud
        {
            get { return salud; }
            set { salud = value; }
        }

        public double Pension
        {
            get { return pension; }
            set { pension = value; }
        }

        public double Afiliación
        {
            get { return afili; }
            set { afili = value; }
        }
    }
}
