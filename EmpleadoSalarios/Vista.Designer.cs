namespace EmpleadoSalarios
{
    partial class Vista
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNom = new System.Windows.Forms.Label();
            this.txtBoxNom = new System.Windows.Forms.TextBox();
            this.lblApe = new System.Windows.Forms.Label();
            this.txtBoxApe = new System.Windows.Forms.TextBox();
            this.lblTel = new System.Windows.Forms.Label();
            this.txtBoxTel = new System.Windows.Forms.TextBox();
            this.BtnAgreg = new System.Windows.Forms.Button();
            this.lblHoras = new System.Windows.Forms.Label();
            this.txtBoxHoras = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefonos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Horas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subsidio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EPS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AFP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Devengado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ARL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Parafiscales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ICBF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CajaComp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salud = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pension = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AfiliacionLaboral = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prima = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cesantias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IntCesantias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vacaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.Location = new System.Drawing.Point(49, 27);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(66, 18);
            this.lblNom.TabIndex = 0;
            this.lblNom.Text = "Nombre:";
            // 
            // txtBoxNom
            // 
            this.txtBoxNom.Location = new System.Drawing.Point(23, 48);
            this.txtBoxNom.Name = "txtBoxNom";
            this.txtBoxNom.Size = new System.Drawing.Size(118, 21);
            this.txtBoxNom.TabIndex = 1;
            // 
            // lblApe
            // 
            this.lblApe.AutoSize = true;
            this.lblApe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApe.Location = new System.Drawing.Point(250, 27);
            this.lblApe.Name = "lblApe";
            this.lblApe.Size = new System.Drawing.Size(63, 18);
            this.lblApe.TabIndex = 2;
            this.lblApe.Text = "Apellido:";
            // 
            // txtBoxApe
            // 
            this.txtBoxApe.Location = new System.Drawing.Point(220, 48);
            this.txtBoxApe.Name = "txtBoxApe";
            this.txtBoxApe.Size = new System.Drawing.Size(118, 21);
            this.txtBoxApe.TabIndex = 3;
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTel.Location = new System.Drawing.Point(463, 27);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(70, 18);
            this.lblTel.TabIndex = 4;
            this.lblTel.Text = "Teléfono:";
            // 
            // txtBoxTel
            // 
            this.txtBoxTel.Location = new System.Drawing.Point(439, 48);
            this.txtBoxTel.Name = "txtBoxTel";
            this.txtBoxTel.Size = new System.Drawing.Size(118, 21);
            this.txtBoxTel.TabIndex = 5;
            // 
            // BtnAgreg
            // 
            this.BtnAgreg.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgreg.Location = new System.Drawing.Point(863, 18);
            this.BtnAgreg.Name = "BtnAgreg";
            this.BtnAgreg.Size = new System.Drawing.Size(143, 76);
            this.BtnAgreg.TabIndex = 8;
            this.BtnAgreg.Text = "Agregar";
            this.BtnAgreg.UseVisualStyleBackColor = true;
            this.BtnAgreg.Click += new System.EventHandler(this.BtnAgreg_Click);
            // 
            // lblHoras
            // 
            this.lblHoras.AutoSize = true;
            this.lblHoras.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoras.Location = new System.Drawing.Point(700, 27);
            this.lblHoras.Name = "lblHoras";
            this.lblHoras.Size = new System.Drawing.Size(53, 18);
            this.lblHoras.TabIndex = 10;
            this.lblHoras.Text = "Horas:";
            // 
            // txtBoxHoras
            // 
            this.txtBoxHoras.Location = new System.Drawing.Point(667, 48);
            this.txtBoxHoras.Name = "txtBoxHoras";
            this.txtBoxHoras.Size = new System.Drawing.Size(118, 21);
            this.txtBoxHoras.TabIndex = 11;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Num,
            this.Nombres,
            this.Apellidos,
            this.Telefonos,
            this.Horas,
            this.Subsidio,
            this.EPS,
            this.AFP,
            this.Devengado,
            this.ARL,
            this.Salary});
            this.dataGridView2.Location = new System.Drawing.Point(23, 136);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(1090, 214);
            this.dataGridView2.TabIndex = 9;
            // 
            // Num
            // 
            this.Num.HeaderText = "Numéro";
            this.Num.Name = "Num";
            this.Num.ReadOnly = true;
            this.Num.Width = 90;
            // 
            // Nombres
            // 
            this.Nombres.HeaderText = "Nombre";
            this.Nombres.Name = "Nombres";
            // 
            // Apellidos
            // 
            this.Apellidos.HeaderText = "Apellido";
            this.Apellidos.Name = "Apellidos";
            // 
            // Telefonos
            // 
            this.Telefonos.HeaderText = "Teléfono";
            this.Telefonos.Name = "Telefonos";
            this.Telefonos.Width = 90;
            // 
            // Horas
            // 
            this.Horas.HeaderText = "Hora-Ordinaria";
            this.Horas.Name = "Horas";
            // 
            // Subsidio
            // 
            this.Subsidio.HeaderText = "Subsidio T.";
            this.Subsidio.Name = "Subsidio";
            // 
            // EPS
            // 
            this.EPS.HeaderText = "EPS";
            this.EPS.Name = "EPS";
            this.EPS.Width = 85;
            // 
            // AFP
            // 
            this.AFP.HeaderText = "AFP";
            this.AFP.Name = "AFP";
            this.AFP.Width = 85;
            // 
            // Devengado
            // 
            this.Devengado.HeaderText = "Devengados";
            this.Devengado.Name = "Devengado";
            // 
            // ARL
            // 
            this.ARL.HeaderText = "ARL";
            this.ARL.Name = "ARL";
            this.ARL.Width = 80;
            // 
            // Salary
            // 
            this.Salary.HeaderText = "Salario Total";
            this.Salary.Name = "Salary";
            this.Salary.Width = 108;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(507, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 33);
            this.label1.TabIndex = 12;
            this.label1.Text = "NÓMINA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(508, 392);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "LIQUIDACIÓN";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Parafiscales,
            this.Sena,
            this.ICBF,
            this.CajaComp,
            this.Salud,
            this.Pension,
            this.AfiliacionLaboral,
            this.Prima,
            this.Cesantias,
            this.IntCesantias,
            this.Vacaciones});
            this.dataGridView1.Location = new System.Drawing.Point(12, 438);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1101, 150);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Parafiscales
            // 
            this.Parafiscales.HeaderText = "Parafiscales:";
            this.Parafiscales.Name = "Parafiscales";
            this.Parafiscales.Width = 85;
            // 
            // Sena
            // 
            this.Sena.HeaderText = "Sena";
            this.Sena.Name = "Sena";
            this.Sena.Width = 85;
            // 
            // ICBF
            // 
            this.ICBF.HeaderText = "I.C.B.F";
            this.ICBF.Name = "ICBF";
            this.ICBF.Width = 85;
            // 
            // CajaComp
            // 
            this.CajaComp.HeaderText = "Caja Compen";
            this.CajaComp.Name = "CajaComp";
            this.CajaComp.Width = 105;
            // 
            // Salud
            // 
            this.Salud.HeaderText = "Salud";
            this.Salud.Name = "Salud";
            this.Salud.Width = 90;
            // 
            // Pension
            // 
            this.Pension.HeaderText = "Pensión";
            this.Pension.Name = "Pension";
            this.Pension.Width = 90;
            // 
            // AfiliacionLaboral
            // 
            this.AfiliacionLaboral.HeaderText = "ARL";
            this.AfiliacionLaboral.Name = "AfiliacionLaboral";
            // 
            // Prima
            // 
            this.Prima.HeaderText = "Prima";
            this.Prima.Name = "Prima";
            // 
            // Cesantias
            // 
            this.Cesantias.HeaderText = "Cesantías";
            this.Cesantias.Name = "Cesantias";
            // 
            // IntCesantias
            // 
            this.IntCesantias.HeaderText = "Int. Cesantías";
            this.IntCesantias.Name = "IntCesantias";
            this.IntCesantias.Width = 105;
            // 
            // Vacaciones
            // 
            this.Vacaciones.HeaderText = "Vacaciones";
            this.Vacaciones.Name = "Vacaciones";
            // 
            // Vista
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1132, 600);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxHoras);
            this.Controls.Add(this.lblHoras);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.BtnAgreg);
            this.Controls.Add(this.txtBoxTel);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.txtBoxApe);
            this.Controls.Add(this.lblApe);
            this.Controls.Add(this.txtBoxNom);
            this.Controls.Add(this.lblNom);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Vista";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox txtBoxNom;
        private System.Windows.Forms.Label lblApe;
        private System.Windows.Forms.TextBox txtBoxApe;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.TextBox txtBoxTel;
        private System.Windows.Forms.Button BtnAgreg;
        private System.Windows.Forms.Label lblHoras;
        private System.Windows.Forms.TextBox txtBoxHoras;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefonos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Horas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subsidio;
        private System.Windows.Forms.DataGridViewTextBoxColumn EPS;
        private System.Windows.Forms.DataGridViewTextBoxColumn AFP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Devengado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ARL;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salary;
        private System.Windows.Forms.DataGridViewTextBoxColumn Parafiscales;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sena;
        private System.Windows.Forms.DataGridViewTextBoxColumn ICBF;
        private System.Windows.Forms.DataGridViewTextBoxColumn CajaComp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salud;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pension;
        private System.Windows.Forms.DataGridViewTextBoxColumn AfiliacionLaboral;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prima;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cesantias;
        private System.Windows.Forms.DataGridViewTextBoxColumn IntCesantias;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vacaciones;
    }
}

