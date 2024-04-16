using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmpleadoSalarios
{
    public class EmpleadoControlador
    {
        private List<Empleado> empleados = new List<Empleado>(); //Lista empleados
        public int NameCounter { get; } = 1; //Numeración Emp
        public const int MaxEmpleados = 3; //Num Max Emp

        public const double ValorHora = 6373; //Valor pesos
        public double HorasAbril = 204; //Horas
        public double Devengado;
       
        public void AddEmpleado(string nombre, string apellido, string telefono, int horas, double subsidio, double eps, double afp, 
            double devengado, double arl, double salario, double nominaTotal, double sena, double icbf, double cajacomp, double salud,
            double pension, double afiliacion) //método añadir emp
        {
            do
            {
               if (empleados.Count >= MaxEmpleados)
               {
                    MessageBox.Show("ERROR. Se ha alcanzado el límite máximo de empleados. "+MaxEmpleados);
                    break;
               }

               if (!Regex.IsMatch(nombre, @"^[a-zA-Z\s]+$"))
               {
                  throw new ArgumentException("Por favor, introduce un nombre válido. Solo se permiten letras.");
               }
               if (!Regex.IsMatch(apellido, @"^[a-zA-Z\s]+$"))
               {
                throw new ArgumentException("Por favor, introduce un apellido válido. Solo se permiten letras.");
               }
               if (!Regex.IsMatch(telefono, @"^[0-9]+$"))
               {
                throw new ArgumentException("Por favor, introduce un número telefónico válido.");
               }

                empleados.Add(new Empleado
                {
                    Nombre = nombre,
                    Apellido = apellido,
                    Telefono = telefono,
                    Horas = horas,
                    Subsidio = subsidio,
                    EPS = eps,
                    AFP= afp,
                    Devengado = devengado,
                    ARL = arl,
                    Sena = sena,
                    ICBF = icbf,
                    CajaComp = cajacomp,
                    Salud = salud,
                    Pension = pension,
                    Afiliación = afiliacion
                });
            } while (false);
        }

        public void CalcularDevengado() //método devengado
        {
            foreach(var empleado in empleados)
            {
                double salarioBase = empleado.Horas * ValorHora;
                double devengado = salarioBase + empleado.Subsidio;
                empleado.Devengado = devengado;
            }
        }

        public void CalcularSalud() //Método Salud
        {
            foreach (var empleado in empleados)
            {
                double saludBase = empleado.Devengado - empleado.Subsidio;
                double eps = saludBase * 0.04; 
                empleado.EPS = Math.Round(eps,1);
            }
        }

        public void CalcularPension() //Método Pension & verificar si se pueden los metodos de void a double
        {
            foreach (var empleado in empleados)
            {
                double pensionBase = empleado.Devengado - empleado.Subsidio;
                double afp = pensionBase * 0.04;
                empleado.AFP = Math.Round(afp,1);
            }
        }

        public void CalcularARL() //Método ARL
        {
            foreach (var empleado in empleados)
            {
                double riesgoBase = empleado.Devengado - empleado.Subsidio;
                double arl = riesgoBase * 0.0696;
                empleado.ARL = Math.Round(arl,1);
            }
        }

        public void CalcularSalarios() //método horas
        {
            foreach (var empleado in empleados)
            {
                double salarioBase = empleado.Horas * ValorHora; //calcular salario base
                double salarioTotal = salarioBase + empleado.Subsidio - empleado.EPS - empleado.AFP;
                empleado.Salario = salarioTotal;
            }
        }

        public double   CalcularNominaTotal() //método calcular nómina
        {
            double nominaTotal = 0;
            foreach (var empleado in empleados)
            {
                nominaTotal += empleado.Devengado;
            }
            return nominaTotal;
        }

        //DatagridView1
        public double CalcularLiquidacion() //método calcular base liquidación
        {
            double totalDevengado = 0;
            double totalSubsidio = 0;

            foreach (var empleado in empleados)
            {
                totalDevengado += empleado.Devengado;
            }

            foreach (var empleado in empleados)
            {
                totalSubsidio += empleado.Subsidio;
            }
            double liquidacion = totalDevengado - totalSubsidio;
            return liquidacion;
        }

        public double Sena() //Metodo Parafiscal
        {
            double liquidacionTotal = CalcularLiquidacion();
            double sena = liquidacionTotal * 0.02;
            // MessageBox.Show($"El valor del Sena es: {sena}");
            return sena;
        }

        public double ICBF() //Metodo Parafiscal
        {
            double liquidacionTotal = CalcularLiquidacion();
            double icbf = liquidacionTotal * 0.03;
            //MessageBox.Show($"El valor del icbf es: {icbf}");
            return icbf;
        }

        public double CajaComp() //Metodo Parafiscal
        {
            double liquidacionTotal = CalcularLiquidacion();
            double cajacomp = liquidacionTotal * 0.04;
            //MessageBox.Show($"El valor del icbf es: {icbf}");
            return cajacomp;
        }

        public double Salud() //Metodo Parafiscal
        {
            double liquidacionTotal = CalcularLiquidacion();
            double salud = liquidacionTotal * 0.085;
            //MessageBox.Show($"El valor del icbf es: {icbf}");
            return salud;
        }

        public double Pension() //Metodo Parafiscal
        {
            double liquidacionTotal = CalcularLiquidacion();
            double pension = liquidacionTotal * 0.12;
            //MessageBox.Show($"El valor del icbf es: {icbf}");
            return pension;
        }

        public double Afiliacion() //Metodo Parafiscal ARL
        {
            double liquidacionTotal = CalcularLiquidacion();
            double afiliacion = liquidacionTotal * 0.0696;
            //MessageBox.Show($"El valor del icbf es: {icbf}");
            return afiliacion;
        }

        public List<Empleado> GetEmpleados() //método público que devuelve la lista de empleados
        {
            return empleados;
        }

    }
}
