using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmpleadoSalarios
{
    public partial class Vista : Form
    {
        private EmpleadoControlador Control = new EmpleadoControlador(); //objeto de la clase
     
        public Vista() //constuctor
        {
            InitializeComponent();
            txtBoxHoras.KeyPress += TxtBoxSalar_KeyPress;
            BtnAgreg.Click += BtnAgreg_Click;
        }

        private void MostrarEmpleados() // Método para ver los empleados
        {
            Control.CalcularDevengado();
            Control.CalcularSalud();
            Control.CalcularPension();
            Control.CalcularARL();
            Control.CalcularSalarios(); //Mediante el objeto accedemos al método calcularSalarios del Controlador

            dataGridView2.Rows.Clear();
            int counter = 1; //contador
 
            double nominaTotal = Control.CalcularNominaTotal(); // Variable para almacenar la nómina total
            double liquidTotal = Control.CalcularLiquidacion();

            foreach (var emp in Control.GetEmpleados())
            {
                dataGridView2.Rows.Add(counter++, emp.Nombre, emp.Apellido, emp.Telefono, emp.Horas, emp.Subsidio.ToString("C"),emp.EPS.ToString("C"),
                    emp.AFP.ToString("C"),emp.Devengado.ToString("C"), emp.ARL.ToString("C"), emp.Salario.ToString("C"));
            }
            dataGridView2.Rows.Add("Nómina Total:", nominaTotal.ToString("C"));

            dataGridView2.Rows.Add("B. Liquidación:", liquidTotal.ToString("C"));

        }

        private void BtnAgreg_Click(object sender, EventArgs e)
        {
            Agregar(); //Llamamos al método Agregar
            dataGridView1.Rows.Clear();
            MostrarLiquidación();
        }

        private void TxtBoxSalar_KeyPress(object sender, KeyPressEventArgs e) //método tecla enter
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                BtnAgreg.PerformClick();
                e.Handled = true;
            }
        }

        private int filaActual = 0;
        private void MostrarLiquidación() //Datagrid liquidación
        {
            Control.Sena();
            int counter = 1;
            dataGridView1.Rows.Clear();
           

          /*  double sena = Control.Sena();*/
            double icbf = Control.ICBF();
            double cajacomp = Control.CajaComp();
            double salud = Control.Salud();
            double pension = Control.Pension();
            double afiliacion = Control.Afiliacion();


            foreach (var emp in Control.GetEmpleados())
            {
                if (filaActual < dataGridView1.Rows.Count)
                {
                    dataGridView1.Rows[filaActual].Cells["Sena"].Value = emp.Sena.ToString("C");
                    filaActual++;
                }
                else
                {
                   
                 dataGridView1.Rows.Add(counter++, emp.Sena.ToString("C"));
                }
            }
                    /*dataGridView1.Rows.Add(counter++, sena.ToString("C"));
            /*(counter++, sena.ToString("C"), icbf.ToString("C"), cajacomp.ToString("C"), salud.ToString("C"), pension.ToString("C"),
            afiliacion.ToString("C"));*/

            /*foreach (var emp in Control.GetEmpleados())
            {
                dataGridView1.Rows.Add(counter++, sena.ToString("C"), icbf.ToString("C"), cajacomp.ToString("C"), salud.ToString("C"), pension.ToString("C"),
                afiliacion.ToString("C"));
            }*/
        }

        private void Agregar() //Método del botón
        {
            string nombre = txtBoxNom.Text;
            string apellido = txtBoxApe.Text;
            string telefono = txtBoxTel.Text;

            if (!int.TryParse(txtBoxHoras.Text, out int horas)) // Convertir las horas a un int
            {
                //MessageBox.Show("Por favor, introduce un valor numérico para las horas.");
                return;
            }
            if (!double.TryParse(txtBoxHoras.Text, out double devengado))
            {
                // Manejo de errores
                return;
            }

            double salario = (2);

            double descuento = (2);
            MessageBox.Show($"Descuentos: {descuento}");

            double nominaTotal = (2);
            double subsidio = (2);
            double eps = (2);
            double afp = (2);
            double arl = (2);
            double sena = Control.Sena();
            double icbf = Control.ICBF();
            double cajacomp = Control.CajaComp();
            double salud = Control.Salud();
            double pension = Control.Pension();
            double afiliacion = Control.Afiliacion();
            
            try
            {
                Control.AddEmpleado(nombre, apellido, telefono, horas, subsidio, eps, afp, devengado, arl, salario, nominaTotal, sena, icbf,
                    cajacomp, salud, pension, afiliacion);
                MostrarEmpleados();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            } 

            txtBoxNom.Clear();
            txtBoxApe.Clear();
            txtBoxTel.Clear();
            txtBoxHoras.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            InitializeComponent();
        }
    }
}
